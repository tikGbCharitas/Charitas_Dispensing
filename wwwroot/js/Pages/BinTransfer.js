const locationID = $("#selectLocation").val() || $("select[name='LocID']").val() ||
    $("#selectedLocation").data("locid") || "";
let currentTransferIndex = -1;
let selectedBinID = null;
let selectedBinName = '';
let selectedItems = [];
let availableBins = [];
let currentWizardStep = 1;

// URL constants (set by server in Index.cshtml)
// GetBinsWithItemCountUrl
// GetBinItemsUrl
// GetAvailableBinsUrl
// AddTransferGroupUrl
// ProcessTransferUrl

document.addEventListener('DOMContentLoaded', function () {
    initializeEventHandlers();
    //loadBinList();
});

function initializeEventHandlers() {
    $(document).on('click', '#btnAddTransfer', function(e) {
        e.preventDefault();
        showTransferWizard();
    });
    
    $(document).on('click', '#btnProcessTransfer', function(e) {
        e.preventDefault();
        processAllTransfers();
    });

    // Wizard navigation
    $('#wizardBtnNext').on('click', nextWizardStep);
    $('#wizardBtnPrev').on('click', prevWizardStep);
    $('#wizardBtnFinish').on('click', finishWizard);

    // Wizard step 1 - Bin selection
    $('#wizardBinSearch').on('keydown', function (e) {
        if (e.key === 'Enter' || e.which === 13) {
            e.preventDefault();
            filterWizardBinList($(this).val());
        }
    });
    $('#wizardBinSearchButton').on('click', loadWizardBinList)

    // Wizard step 2 - Item selection
    $('#wizardItemSearch').on('keydown', function (e) {
        if (e.key === 'Enter' || e.which === 13) {
            e.preventDefault();
            filterWizardItemList($(this).val());
        }
    });
    $('#wizardItemSearchButton').on('click', loadWizardBinItems)

    $('#wizardSelectAll').on('click', wizardSelectAllItems);
    $('#wizardDeselectAll').on('click', wizardDeselectAllItems);
    $(document).on('change', '.wizard-item-checkbox', updateWizardSelectedCount);

    // Wizard step 3 - Destination selection
    //$('#wizardDestinationBinSelect').on('change', function () {
    //    const hasValue = $(this).val() !== '';
    //    console.log($(this).val())
    //    $('#wizardBtnFinish').prop('disabled', !hasValue);
    //});

    // Transfer group actions
    $(document).on('click', '.btn-remove-transfer', removeTransferGroup);

    // Modal reset on close
    $('#transferWizardModal').on('hidden.bs.modal', resetWizard);    
}

function showTransferWizard() {
    // Check if modal element exists
    const modalElement = document.getElementById('transferWizardModal');
    if (!modalElement) {
        showError('Modal not found. Please refresh the page.');
        return;
    }
       
    resetWizard();
    
    // Use Bootstrap 5 Modal API
    try {
        const modal = new bootstrap.Modal(modalElement, {
            backdrop: 'static',
            keyboard: false
        });
        modal.show();
    } catch (error) {
        // Fallback to jQuery if Bootstrap 5 fails
        try {
            $('#transferWizardModal').modal('show');
        } catch (jqError) {
            showError('Cannot open modal. Please check console for errors.');
        }
    }
    
    loadWizardBinList();
}

function resetWizard() {
    currentWizardStep = 1;
    selectedBinID = null;
    selectedBinName = '';
    selectedItems = [];

    // Destroy Select2 if initialized
    const select = $('#wizardDestinationBinSelect');
    if (select.hasClass('select2-hidden-accessible')) {
        // Remove all Select2 events before destroying
        select.off('select2:open');
        select.off('select2:opening');
        select.off('change.select2');
        select.select2('destroy');
    }

    // Reset wizard UI
    updateWizardStep(1);
    $('#wizardBinSearch').val('');
    $('#wizardItemSearch').val('');
    $('#wizardDestinationBinSelect').val('').empty();
    $('#wizardBtnNext').prop('disabled', true);
    $('#wizardBtnFinish').prop('disabled', true);
}

function updateWizardStep(step) {
    currentWizardStep = step;

    // Update step indicators
    $('.wizard-steps .step').each(function () {
        const stepNum = parseInt($(this).data('step'));
        $(this).removeClass('active completed');
        if (stepNum < step) {
            $(this).addClass('completed');
        } else if (stepNum === step) {
            $(this).addClass('active');
        }
    });

    // Show/hide content
    $('.wizard-content').hide();
    $(`#step${step}Content`).show();

    // Update navigation buttons
    $('#wizardBtnPrev').toggle(step > 1);
    $('#wizardBtnNext').toggle(step < 3);
    $('#wizardBtnFinish').toggle(step === 3);

    // Disable next by default
    if (step === 1) {
        $('#wizardBtnNext').prop('disabled', !selectedBinID);
    } else if (step === 2) {
        $('#wizardBtnNext').prop('disabled', true);
        updateWizardSelectedCount();
    } else if (step === 3) {
        $('#wizardBtnFinish').prop('disabled', true);
        prepareStep3();
    }
}

function nextWizardStep() {
    if (currentWizardStep === 1) {
        if (!selectedBinID) {
            showError('Please select a bin first');
            return;
        }
        loadWizardBinItems();
        updateWizardStep(2);
    } else if (currentWizardStep === 2) {
        const selectedItemIDs = [];
        $('.wizard-item-checkbox:checked').each(function () {
            selectedItemIDs.push({
                itemID: $(this).data('item-id'),
                itemName: $(this).data('item-name'),
                totalQuantity: $(this).data('total-quantity'),
                variantCount: $(this).data('variant-count')
            });
        });

        if (selectedItemIDs.length === 0) {
            showError('Please select at least one item');
            return;
        }

        selectedItems = selectedItemIDs;
        loadWizardAvailableBins();
        updateWizardStep(3);
    }
}

function prevWizardStep() {
    if (currentWizardStep > 1) {
        updateWizardStep(currentWizardStep - 1);
    }
}

function finishWizard() {
    const destinationBinID = parseInt($('#wizardDestinationBinSelect').val());
    const destinationBinName = $('#wizardDestinationBinSelect option:selected').text();

    if (!destinationBinID) {
        showError('Please select a destination bin');
        return;
    }

    // Show loading
    Swal.fire({
        title: 'Loading...',
        text: 'Adding transfer to list',
        allowOutsideClick: false,
        didOpen: () => {
            Swal.showLoading();
        }
    });
    // Prepare selected items data
    const selectedItemsData = selectedItems.map(item => ({
        ItemID: item.itemID,
        ItemName: item.itemName,
        TotalQuantity: item.totalQuantity,
        VariantCount: item.variantCount
    }));

    var token = $('input[name="__RequestVerificationToken"]').val();

    $.ajax({
        url: AddTransferGroupUrl,
        type: 'POST',
        headers: {
            'RequestVerificationToken': token,
            'X-Requested-With': 'XMLHttpRequest'
        },
        contentType: 'application/json',
        data: JSON.stringify({
            locationID: locationID,
            fromBinID: selectedBinID,
            fromBinName: selectedBinName,
            toBinID: destinationBinID,
            toBinName: destinationBinName,
            selectedItemsPayload: selectedItemsData
        }),
        success: function (html) {
            // Server returns rendered HTML - just replace container
            $('#transferContainer').append(html);
            
            Swal.close();
            $('#transferWizardModal').modal('hide');
            updateSummary();
            showSuccess('Transfer added successfully');
        },
        error: function (xhr) {
            Swal.close();
            let errorMsg = 'Failed to add transfer';
            try {
                const response = JSON.parse(xhr.responseText);
                if (response.message) {
                    errorMsg = response.message;
                }
            } catch (e) {}
            showError(errorMsg);
        }
    });
}

// Step 1: Load bin list
function loadWizardBinList() {
    $.ajax({
        url: GetBinsWithItemCountUrl,
        type: 'GET',
        data: {
            locationID: locationID,
            searchQuery: $('#wizardBinSearch').val() || ""
        },
        headers: {
            'X-Requested-With': 'XMLHttpRequest'
        },
        success: function (html) {
            // Server returns rendered HTML, just replace it
            $('#wizardBinListContainer').html(html);
            
            // Attach click handlers to dynamically loaded bins
            attachBinClickHandlers();
        },
        error: function () {
            showError('Failed to load bin list');
        }
    });
}

function attachBinClickHandlers() {
    $('.wizard-bin-item').off('click').on('click', function (e) {
        e.preventDefault();
        const binID = $(this).data('bin-id');
        const binName = $(this).data('bin-name');
        selectWizardBin(binID, binName);
    });
}

function filterWizardBinList(searchTerm) {
    //$('.wizard-bin-item').each(function () {
    //    const binName = $(this).data('bin-name').toLowerCase();
    //    const matches = binName.includes(searchTerm.toLowerCase());
    //    $(this).toggle(matches);
    //});
    loadWizardBinList();
}

function selectWizardBin(binID, binName) {
    selectedBinID = binID;
    selectedBinName = binName;
    $('#wizardSelectedBinName').text(binName);

    // Highlight selected bin
    $('.wizard-bin-item').removeClass('active');
    $(`.wizard-bin-item[data-bin-id="${binID}"]`).addClass('active');

    $('#wizardBtnNext').prop('disabled', false);
}

// Step 2: Load items (grouped by ItemID)
function loadWizardBinItems() {
    $.ajax({
        url: GetBinItemsUrl,
        type: 'GET',
        data: {
            locationID: locationID,
            binID: selectedBinID,
            searchQuery: $('#wizardItemSearch').val() || ""
        },
        headers: {
            'X-Requested-With': 'XMLHttpRequest'
        },
        success: function (html) {
            // Server returns rendered HTML, just replace it
            $('#wizardItemListContainer').html(html);
            
            // Attach event handlers
            attachItemEventHandlers();
            updateWizardSelectedCount();
        },
        error: function () {
            showError('Failed to load items');
        }
    });
}

function attachItemEventHandlers() {
    // Checkbox change handler
    $('.wizard-item-checkbox').off('change').on('change', updateWizardSelectedCount);
    
    // Show variants button handler
    $('.btn-show-variants').off('click').on('click', function (e) {
        e.preventDefault();
        const itemID = $(this).data('item-id');
        toggleVariantsDisplay(itemID);
    });
}

function toggleVariantsDisplay(itemID) {
    const variantsDiv = $(`#variants-${itemID}`);
    const button = $(`.btn-show-variants[data-item-id="${itemID}"]`);
    
    if (variantsDiv.is(':visible')) {
        variantsDiv.slideUp();
        button.find('i').removeClass('bi-eye-slash').addClass('bi-eye');
    } else {
        variantsDiv.slideDown();
        button.find('i').removeClass('bi-eye').addClass('bi-eye-slash');
    }
}

function filterWizardItemList(searchTerm) {
    //$('.wizard-item-card').each(function () {
    //    const text = $(this).text().toLowerCase();
    //    const matches = text.includes(searchTerm.toLowerCase());
    //    $(this).toggle(matches);
    //});
    loadWizardBinItems();
}

function wizardSelectAllItems() {
    $('.wizard-item-checkbox:visible').prop('checked', true);
    updateWizardSelectedCount();
}

function wizardDeselectAllItems() {
    $('.wizard-item-checkbox').prop('checked', false);
    updateWizardSelectedCount();
}

function updateWizardSelectedCount() {
    const count = $('.wizard-item-checkbox:checked').length;
    $('#wizardSelectedItemCount').text(count);
    if (currentWizardStep === 2) {
        $('#wizardBtnNext').prop('disabled', count === 0);
    }
}

// Step 3: Destination
function prepareStep3() {
    $('#wizardSummarySourceBin').text(selectedBinName);
    const itemCount = $('.wizard-item-checkbox:checked').length;
    $('#wizardSummaryItemCount').text(`${itemCount} item(s)`);
}

function loadWizardAvailableBins() {
    $.ajax({
        url: GetAvailableBinsUrl,
        type: 'GET',
        data: {
            locationID: locationID,
            excludeBinID: selectedBinID
        },
        success: function (response) {
            if (response.success && response.bins) {
                populateWizardDestinationBins(response.bins, response.firstSelection);
            }
        },
        error: function () {
            showError('Failed to load destination bins');
        }
    });
}

function populateWizardDestinationBins(bins, firstSelection) {
    const select = $('#wizardDestinationBinSelect');
    select.empty().append(`<option value="">-- ${firstSelection} --</option>`);

    bins.forEach(bin => {
        select.append(`<option value="${bin.binID}">${bin.binName}</option>`);
    });
    
    // Initialize or reinitialize Select2
    if (select.hasClass('select2-hidden-accessible')) {
        select.select2('destroy');
    }
    
    select.select2({
        theme: 'bootstrap-5',
        dropdownParent: $('#transferWizardModal'),
        placeholder: firstSelection,
        allowClear: true,
        width: '100%',
        language: {
            noResults: function() {
                return "No bins found";
            }
        },
        // Enable search box always (even for few items)
        minimumResultsForSearch: 0
    });
    
    // Auto focus search box when dropdown opens - ROBUST VERSION
    select.on('select2:open', function(e) {
        // Try immediate focus first
        let searchField = document.querySelector('.select2-container--open .select2-search__field');
        
        if (searchField) {
            searchField.focus();
        }
        
        // Also use requestAnimationFrame for better timing
        requestAnimationFrame(function() {
            const field = document.querySelector('.select2-container--open .select2-search__field');
            if (field) {
                field.focus();
            }
        });
        
        // Fallback with setTimeout for slower browsers
        setTimeout(function() {
            const field = document.querySelector('.select2-container--open .select2-search__field');
            if (field) {
                field.focus();
            }
        }, 10);
    });
    
    // Additional event listener for when dropdown is fully rendered
    select.on('select2:opening', function(e) {
        setTimeout(function() {
            const field = document.querySelector('.select2-container--open .select2-search__field');
            if (field) {
                field.focus();
            }
        }, 1);
    });
    
    select.off('select2:select select2:clear change').on('select2:select', function (e) {
        // Triggered when an option is selected
        const selectedValue = e.params.data.id;
        const selectedText = e.params.data.text;

        // Force Select2 to update display
        $(this).val(selectedValue).trigger('change.select2');

        // Alternative: manually update the display text
        const $container = $(this).next('.select2-container');
        $container.find('.select2-selection__rendered').text(selectedText);
        $container.find('.select2-selection__rendered').attr('title', selectedText);

        // Enable finish button
        $('#wizardBtnFinish').prop('disabled', false);

    }).on('select2:clear', function (e) {
        // Triggered when selection is cleared
        $('#wizardBtnFinish').prop('disabled', true);

    }).on('change', function () {
        // Fallback for manual value changes
        const hasValue = $(this).val() !== '' && $(this).val() !== null;

        if (hasValue) {
            // Force update display if not showing correct text
            const selectedText = $(this).find('option:selected').text();
            const $container = $(this).next('.select2-container');
            const displayedText = $container.find('.select2-selection__rendered').text();

            if (displayedText !== selectedText) {
                $container.find('.select2-selection__rendered').text(selectedText);
                $container.find('.select2-selection__rendered').attr('title', selectedText);
            }
        }

        $('#wizardBtnFinish').prop('disabled', !hasValue);
    });
}

// Transfer groups management
function removeTransferGroup(e) {
    const groupElement = $(e.currentTarget).closest('.transfer-group');

    Swal.fire({
        title: 'Remove Transfer?',
        text: 'Are you sure you want to remove this transfer?',
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#d33',
        cancelButtonColor: '#3085d6',
        confirmButtonText: 'Yes, remove it'
    }).then((result) => {
        if (result.isConfirmed) {
            // Simply remove the element from DOM
            groupElement.remove();
            
            // Update summary after removal
            updateSummary();
            showSuccess('Transfer removed');
        }
    });
}

function updateSummary() {
    // Count transfer groups from DOM
    const totalTransfers = $('.transfer-group').length;

    // Calculate total items and quantity from DOM
    let totalItems = 0;
    let totalQuantity = 0;

    $('.transfer-group').each(function () {
        // Get accordion button text which contains item count and total qty
        const accordionButton = $(this).find('.accordion-button').first();

        // Extract item count from "X Item(s) - Total Qty: Y" format
        const itemCount = parseInt(accordionButton.data('item-count')) || 0;
        totalItems += itemCount

        // Extract total quantity
        const qty = parseFloat(accordionButton.data('total-qty')) || 0;
        totalQuantity += qty;

    });

    $('#totalTransfers').text(totalTransfers);
    $('#totalItems').text(totalItems);
    $('#totalQuantity').text(totalQuantity.toFixed(2));
    
    // Show/hide summary card and process button
    if (totalTransfers > 0) {
        $('#emptyState').hide();
        $('#summaryCard').show();
        $('#btnProcessTransfer').prop('disabled', false);
    } else {
        $('#emptyState').show();
        $('#summaryCard').hide();
        $('#btnProcessTransfer').prop('disabled', true);
    }
}

function processAllTransfers() {
    Swal.fire({
        title: 'Process All Transfers?',
        text: 'You are about to process all pending transfers',
        icon: 'question',
        showCancelButton: true,
        confirmButtonColor: '#28a745',
        cancelButtonColor: '#6c757d',
        confirmButtonText: 'Yes, process now'
    }).then((result) => {
        if (result.isConfirmed) {
            executeTransfer();
        }
    });
}

function executeTransfer() {
    Swal.fire({
        title: 'Loading...',
        text: 'Preparing transfer data',
        allowOutsideClick: false,
        didOpen: () => {
            Swal.showLoading();
        }
    });

    // Collect all transfer data from DOM
    const transferData = [];
    
    $('.transfer-group').each(function() {
        const $group = $(this);
        
        // Get bin names from badges
        const fromBinID = $group.find('.bin-badge.bg-primary').data('from-binid');
        const toBinID = $group.find('.bin-badge.bg-success').data('to-binid');
        
        // Get items from accordion body
        const items = [];
        $group.find('.accordion-body .border').each(function() {
            const $item = $(this);
            const itemID = $item.find('small.text-muted').text().trim();
            
            items.push({
                itemID: itemID
            });
        });
        
        transferData.push({
            fromBinID: fromBinID,
            toBinID: toBinID,
            items: items
        });
    });

    if (transferData.length === 0) {
        Swal.close();
        showError('No transfer data found');
        return;
    }
    
    Swal.close();
    processTransferItems(transferData)
}

function processTransferItems(transferItems) {
    if (!transferItems || !Array.isArray(transferItems) || transferItems.length === 0) {
        Swal.fire({
            icon: 'error',
            title: 'Error',
            text: 'No transfer data to process',
            confirmButtonColor: '#d33'
        });
        return;
    }

    const requestData = {
        LocationID: locationID,
        Items: transferItems
    };

    Swal.fire({
        title: 'Processing...',
        text: 'Please wait while we process your transfer',
        allowOutsideClick: false,
        didOpen: () => {
            Swal.showLoading();
        }
    });

    $.ajax({
        url: ProcessTransferUrl,
        type: 'POST',
        contentType: 'application/json',
        data: JSON.stringify(requestData),
        headers: {
            'RequestVerificationToken': $('input[name="__RequestVerificationToken"]').val()
        },
        success: function (response) {
            if (response.success) {
                Swal.fire({
                    icon: 'success',
                    title: 'Transfer Successful!',
                    html: response.message,
                    confirmButtonColor: '#28a745'
                }).then(() => {
                    updateSummary();
                    loadWizardBinList();
                });
            } else {
                Swal.fire({
                    icon: 'error',
                    title: 'Transfer Failed',
                    html: response.message,
                    confirmButtonColor: '#d33'
                });
            }
        },
        error: function (xhr, status, error) {
            Swal.fire({
                icon: 'error',
                title: 'Error',
                text: 'An error occurred while processing the transfer',
                confirmButtonColor: '#d33'
            });
        }
    });
}

function parseDate(dateString) {
    const parts = dateString.split('/');
    if (parts.length === 3) {
        return `${parts[2]}-${parts[1]}-${parts[0]}T00:00:00`;
    }
    return dateString;
}

function showSuccess(message) {
    Swal.fire({
        icon: 'success',
        title: 'Success',
        text: message,
        toast: true,
        position: 'top-end',
        showConfirmButton: false,
        timer: 5000
    });
}

function showError(message) {
    Swal.fire({
        icon: 'error',
        title: 'Error',
        text: message,
        toast: true,
        position: 'top-end',
        showConfirmButton: false,
        timer: 5000
    });
}