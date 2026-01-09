// #region Global Variable
let ItemList = []
let searchDebounceTimer;
// #endregion

// #region Theme Detection Helper
function getCurrentTheme() {
    return document.documentElement.getAttribute('data-theme') || 
           document.body.getAttribute('data-theme') || 
           'light';
}

function isDarkTheme() {
    return getCurrentTheme() === 'dark';
}
// #endregion

// #region jQuery AJAX Server-Side Search
function performAjaxSearch(searchQuery) {
    const collectionContainer = $("#collectionContainer");
       
    // Get current page context
    const selectionType = $("input[type='hidden'][name='SelectionType']").val() || "Location";
    const locationID = $("#selectedLocation").data("locid") || 
                        $("input[type='hidden'][name='LocID']").val() || "";
    const transactionNo = $("input[type='hidden'][name='TransactionNo']").val() || "";

    if (!locationID) {
        Swal.fire({
            icon: "warning",
            title: "Location",
            text: "Please choose Location",
            allowEscapeKey: false,
            allowOutsideClick: false,
            timer: 5000,
            showConfirmButton: true
        });
        return;
    }
    console.log(selectionType);
    // Show loading indicator
    showLoadingIndicator();
    
    // jQuery AJAX request
    $.ajax({
        url: SearchItemsUrl,
        type: 'GET',
        data: {
            LocID: locationID,
            SelectionType: selectionType,
            TransactionNo: transactionNo,
            searchQuery: searchQuery,
            onViewMode: ViewMode
        },
        success: function (htmlResponse) {
            // Simply replace the container HTML with server-rendered content
            collectionContainer.html(htmlResponse);
            requestAnimationFrame(() => {
                // Restore client state to the new cards
                restoreItemListToCards();

                // Re-attach event listeners to new cards
                attachCardEventListeners();

                initializeBinSelects();

                // Show search result info
                const itemCount = collectionContainer.find('.card-clickable').length;
                updateSearchResultInfo(itemCount, searchQuery);

                // Show/hide clear button
                toggleClearButton(searchQuery);
            })            
        },
        error: function(xhr, status, error) {
            console.error('AJAX search error:', error);
            showErrorMessage("An error occurred while searching. Please try again.");
        }
    });
}
function restoreItemListToCards() {
    ItemList.forEach(savedItem => {
        const card = $(`.card-clickable[data-item-id="${savedItem.ItemID}"]` +
                      `[data-nie-bpom="${savedItem.NIE_BPOM}"]` +
                      `[data-batch-id="${savedItem.BatchID}"]` +
                      `[data-expired-date="${savedItem.ExpiredDate}"]`);
        
        if (card.length > 0 && savedItem.isModified === "true") {
            const cardElement = card[0];
            const cardParent = card.closest('.card');
            
            // Mark card as selected (yellow)
            cardParent.removeClass("bg-light").addClass("bg-warning");
            cardElement.dataset.isModified = "true";
            
            // Enable controls
            card.find("select, input[type='number'], button").prop("disabled", false);
            
            // Set bin selection
            const binSelect = card.find("select[name='BinTarget']");
            if (binSelect.length > 0 && savedItem.BinID) {
                binSelect.val(savedItem.BinID);
                //binSelect.find("option:first").text("-- Select Bin --");
            }
            
            // Set quantity
            const qtyInput = card.find("input[type='number']");
            if (qtyInput.length > 0 && savedItem.BinQty) {
                qtyInput.val(savedItem.BinQty);
            }            
        }
    });
}
function attachCardEventListeners() {
    $('.card-clickable').each(function() {
        const card = $(this);
        const cardParent = card.parent();
        
        if (!cardParent.hasClass('card-lock')) {
            // Remove existing listener to avoid duplicates
            card.off('click').on('click', function(e) {
                const tag = e.target.tagName.toLowerCase();
                const $target = $(e.target);

                // Check if click is on form controls or Select2
                const isSelect2 = $target.hasClass('select2') ||
                                $target.hasClass('select2-selection') ||
                                $target.hasClass('select2-selection__rendered') ||
                                $target.hasClass('select2-selection__arrow') ||
                                $target.closest('.select2').length > 0 ||
                                $target.closest('.select2-container').length > 0;

                if (['select', 'input', 'option', 'button'].includes(tag) || isSelect2) return;
                OpenBatch(this);
            });
        } else {
            card.off('click').on('click', function(e) {
                if (ViewMode) return;
                Swal.fire({
                    icon: "warning",
                    title: "Bin Lock",
                    text: "Please Unlock bin from Bin Stock",
                    allowEscapeKey: false,
                    allowOutsideClick: false,
                    timer: 5000,
                    showConfirmButton: true
                });
            });
        }
    });
}
function updateSearchResultInfo(count, searchQuery) {
    const resultInfo = $("#searchResultInfo");
    const resultCount = $("#searchResultCount");
    
    if (resultInfo.length > 0 && resultCount.length > 0) {
        if (searchQuery && searchQuery.trim() !== "") {
            resultCount.text(`Found ${count} item(s) matching "${searchQuery}"`);
            resultInfo.show();
        } else {
            resultCount.text(`Showing 100 item(s) nearest Expired Date`);
        }
    }
}
function toggleClearButton(searchQuery) {
    const clearBtn = $("#clearSearchButton");
    if (clearBtn.length > 0) {
        if (searchQuery && searchQuery.trim() !== "") {
            clearBtn.show();
        } else {
            clearBtn.hide();
        }
    }
}
function showErrorMessage(message) {
    const container = $("#collectionContainer");
    if (container.length > 0) {
        container.html(`
            <div class="col-12">
                <div class="alert alert-danger">
                    <i class="bi bi-exclamation-triangle"></i> ${message}
                </div>
            </div>
        `);
    }
}
function searchFunction(event) {
    //clearTimeout(searchDebounceTimer);
    
    //const searchQuery = $(event.target).val();
    
    //searchDebounceTimer = setTimeout(() => {
    //    performAjaxSearch(searchQuery);
    //}, 500); // 500ms debounce

    if (event.key === 'Enter' || event.keyCode === 13 || event.which === 13) {
        event.preventDefault();
        const searchQuery = $(event.target).val() || "";
        performAjaxSearch(searchQuery);
    }
}
function clearSearch() {
    const searchInput = $("#searchComponent");
    if (searchInput.length > 0) {
        searchInput.val("");
        performAjaxSearch("");
    }
}
function showLoadingIndicator() {
    const container = $("#collectionContainer");
    if (container.length > 0) {
        container.html(`
            <div class="col-12">
                <div class="d-flex justify-content-center align-items-center" style="min-height: 50vh;">
                    <div class="text-center">
                        <div class="spinner-border text-primary" role="status" style="width: 3rem; height: 3rem;">
                            <span class="visually-hidden">Loading...</span>
                        </div>
                        <p class="mt-3 text-muted fw-semibold">🔍 Searching...</p>
                    </div>
                </div>
            </div>
        `);
    }
}
// #endregion

// #region Selection Type Handler

// Update hidden location field when location dropdown changes
function updateHiddenLocation() {
    const selectLocation = document.getElementById('selectLocation');
    const hiddenLocID = document.getElementById('hiddenLocID');
    
    if (selectLocation && hiddenLocID) {
        hiddenLocID.value = selectLocation.value;
    }
}
// #endregion

document.addEventListener('DOMContentLoaded', () => {
    //LoadFailSavedData();
    //console.log(searchPrev)
    //if (searchPrev) {
    //    const searchTextbox = $("#searchComponent");
    //    if (searchTextbox.length > 0) {
    //        searchTextbox.val(searchPrev);
    //        // Trigger AJAX search if there's a previous search query
    //        if (searchPrev.trim()) {
    //            performAjaxSearch(searchPrev);
    //        }
    //    }
    //}

    // Attach click handlers to cards using unified function
    attachCardEventListeners();

    // Sync location between dropdown and hidden field
    const selectLocation = document.getElementById('selectLocation');
    if (selectLocation) {
        selectLocation.addEventListener('change', updateHiddenLocation);
    }

    const radios = document.querySelectorAll(".radio-selection")
    radios.forEach(radio => {
        radio.addEventListener("change", toggleRadioInput)
    })

    //const selectLocation = document.getElementById('selectLocation');
    //if (selectLocation) {
    //    new TomSelect(selectLocation, {
    //        create: false,
    //        sortField: { field: "text" },
    //        placeholder: "-- Select Location --",
    //        onChange: function (value) {
    //            selectLocation.form.submit();
    //        },
    //        dropdownParent: 'body'
    //    });
    //}

    // Add Enter key support for Transaction No input
    const transactionNoField = document.getElementById('transactionNoField');
    if (transactionNoField) {
        transactionNoField.addEventListener('keypress', function(e) {
            if (e.key === 'Enter') {
                searchTransaction(e);
            }
        });
    }

    // jQuery AJAX SEARCH: Add event listener for search input with debounce
    $("#searchComponent").on("keydown", searchFunction);
    
    // Add click handler for search button
    const searchTransactionBtn = document.getElementById('searchTransactionBtn');
    if (searchTransactionBtn) {
        searchTransactionBtn.addEventListener('click', searchTransaction);
    }
    
    $("#searchButton").on("click", function() {
        const searchQuery = $("#searchComponent").val() || "";
        performAjaxSearch(searchQuery);
    });
    
    // Add click handler for clear button
    $("#clearSearchButton").on("click", clearSearch);
    
    // Initialize Select2 for bin dropdowns
    initializeBinSelects();
    
    // Setup observer for dynamic content
    //setupBinSelectObserver();
    
    const SelectionType = document.querySelector("input[type='hidden'][name='SelectionType']")?.value
    if (SelectionType == "TransactionNo") {
        document.querySelectorAll('.card-clickable').forEach(card => {
            const binQty = card.querySelector(`#input-${card.dataset.itemId}-${card.dataset.nieBpom}-${card.dataset.batchId}`)
            if (binQty && card.dataset.isOpen == "false") {
                binQty.value = card.querySelector(".TransNoQtyMax").textContent
            }
            card.dispatchEvent(new Event("click"))
            if (ItemBinList.length > 0 && card.dataset.isOpen == "false") {
                const selectElement = card.querySelector("select[name='BinTarget']");
                if (selectElement) {
                    const currentValue = selectElement.value;
                    if (!currentValue || currentValue === "" || currentValue === "null") {
                        const firstBin = ItemBinList[0];
                        selectElement.value = firstBin.BinID;
                        selectElement.dispatchEvent(new Event("change"));
                    }
                }
            }
        })
    }
});
function toggleRadioInput(event) {
    const TransNoInput = document.getElementById("transactionNoInput")
    const locationSection = document.getElementById('locationSection');
    if (event.target.value == "TransactionNo") {
        // Show Transaction No input field
        if (TransNoInput) {
            TransNoInput.style.display = "block"
            var transNoField = TransNoInput.querySelector('#transactionNoField');
            if (transNoField.value.trim()) {
                const form = document.getElementById('selectionTypeForm');
                if (form) {
                    form.submit();
                }
            }
            else {
                TransNoInput.querySelector("#LocTransNo").textContent = ''
                 // Focus on the input field for better UX
                setTimeout(() => {
                    if (transNoField) {
                        transNoField.focus();
                    }
                }, 100);
            }
        }

        // Hide Location container if exists
        if (locationSection) {
            locationSection.style.display = "none"
        }

        //const hiddenLocID = document.getElementById('hiddenLocID');
        //if (hiddenLocID) {
        //    hiddenLocID.value = "";
        //}

        const collectioncontainer = document.getElementById("collectionContainer")
        if (collectioncontainer) {
            collectioncontainer.innerHTML = ""
        }
    }
    else {
        // Hide Transaction No input field
        if (TransNoInput) {
            TransNoInput.style.display = "none"
        }
        // Show Location container if exists
        if (locationSection) {
            locationSection.style.display = "block"
        }

        const form = document.getElementById('selectionTypeForm');
        if (form) {
            form.submit();
        }
    }
}
function searchTransaction(event) {
    event.preventDefault();
    var transNoField = document.getElementById('transactionNoField')
    const value = transNoField?.value?.trim();

    if (!value) {
        Swal.fire({
            icon: "warning",
            title: "TransactionNo Error",
            text: "Please enter Transaction No",
            allowEscapeKey: false,
            allowOutsideClick: false,
            timer: 5000,
            showConfirmButton: true
        });
        return;
    }

    const hiddenLocID = document.getElementById('hiddenLocID');
    if (hiddenLocID) {
        hiddenLocID.value = "";
    }

    const form = document.getElementById('selectionTypeForm');
    if (form) {
        form.submit();
    }
}
function MaxQty(element) {
    const max = parseFloat(element.max);
    const val = parseFloat(element.value);

    if (!isNaN(max) && val > max) {
        element.value = max;
    }
    let card = element.closest(".card-clickable")
    for (let item of ItemList) {
        if (item.ItemID === card.dataset.itemId
            && item.NIE_BPOM === card.dataset.nieBpom
            && item.BatchID === card.dataset.batchId
            && item.ExpiredDate === card.dataset.expiredDate) {
            item.BinQty = parseFloat(card.querySelector("input[type='number']").value);
            return;
        }
    }
    let binID = card.find("select[name='BinTarget']").val();
    let binQty = card.querySelector("input[type='number']").value
    ItemList.push({
        ItemID: card.dataset.itemId,
        NIE_BPOM: card.dataset.nieBpom,
        BatchID: card.dataset.batchId,
        ExpiredDate: card.dataset.expiredDate,
        BinID: (binID == "" || binID == null) ? null : parseFloat(binID),
        BinQty: (binQty == "" || binQty == null) ? null : parseFloat(binQty),
        isModified: card.dataset.isModified
    }
    );
}
function AddReduceCF(element, AddReduce, CF) {
    let id;
    if (AddReduce == "add") {
        id = element.id.replace("btnAdd-", "input-");
    }
    else {
        id = element.id.replace("btnReduce-", "input-");
    }

    const input = document.getElementById(id);
    if (!input) return;

    const current = parseFloat(input.value) || 0;
    const max = parseFloat(input.max) || Infinity;

    let newValue = (AddReduce === "add")
        ? current + parseFloat(CF)
        : current - parseFloat(CF);

    newValue = parseFloat(newValue.toFixed(2))

    if (newValue > max) {
        newValue = max;
    }
    else if(newValue < 1){
        newValue = 0;
    }

    input.value = newValue;

    input.dispatchEvent(new Event("change"));
}
function SelectedBin(element) {
    const $element = $(element);
    const $select = $element.is('select') ? $element : $element.find('select');
    const binID = $select.val();
    const $card = $select.closest(".card-clickable");

    if ($card.length === 0) {
        console.error('SelectedBin: Cannot find parent card');
        return;
    }

    const card = $card[0];

    // Update existing item
    const existingItem = ItemList.find(item =>
        item.ItemID === card.dataset.itemId &&
        item.NIE_BPOM === card.dataset.nieBpom &&
        item.BatchID === card.dataset.batchId &&
        item.ExpiredDate === card.dataset.expiredDate
    );

    if (existingItem) {
        existingItem.BinID = (binID === "" || binID === null) ? null : parseFloat(binID);
        console.log('✅ Updated BinID:', existingItem.BinID);
        return;
    }

    // Add new item
    const binQty = card.querySelector("input[type='number']")?.value;

    if (binID !== "" && binID !== null) {
        const newItem = {
            ItemID: card.dataset.itemId,
            NIE_BPOM: card.dataset.nieBpom,
            BatchID: card.dataset.batchId,
            ExpiredDate: card.dataset.expiredDate,
            BinID: parseFloat(binID),
            BinQty: (binQty === "" || binQty === null) ? null : parseFloat(binQty),
            isModified: card.dataset.isModified
        };

        ItemList.push(newItem);
        console.log('✅ Added new item with BinID:', newItem.BinID);
    }
}
function OpenBatch(card) {
    if (ViewMode) return;
    
    // Detect current theme using helper
    const darkTheme = isDarkTheme();
    
    let isOpen = card.dataset.isOpen === "true"
    let isModified = card.dataset.isModified === "true"
    let $binSelect = $(card).find("select[name='BinTarget']");
    let binID = $binSelect.val();
    let binQty = card.querySelector("input[type='number']")
    let binQtyValue = binQty.value
    const webControls = card.querySelectorAll("select, input[type='number'], button");
    
    // Get parent card element
    let parentCard = card.closest('.card');
    
    if (!isOpen) {
        if (!isModified) {
            // Selecting the card - change to warning/yellow
            card.classList.remove("bg-light");
            card.classList.add("bg-warning");
            //card.classList.add("bg-warning", "text-dark");
            
            // Update parent card classes
            //parentCard.classList.remove("bg-light", "batch-card-new");
            //parentCard.classList.add("bg-warning", "text-dark");
            
            // Log for debugging (can be removed in production)
            //if (darkTheme) {
            //    console.log('Dark theme detected - Card selected:', card.dataset.itemId);
            //}
            let cf = parseFloat(card.dataset.cf)
            let blc = parseFloat(card.dataset.balance)
            webControls.forEach(input => input.removeAttribute("disabled"));
            binQtyValue = binQtyValue ? binQtyValue : (cf > blc ? blc : cf)
            binQty.value = parseFloat(binQtyValue)
            //card.querySelector("select").options[0].text = "-- Select Bin --"
            //card.closest('.col').hidden = true
            ItemList.push({
                ItemID: card.dataset.itemId,
                NIE_BPOM: card.dataset.nieBpom,
                BatchID: card.dataset.batchId,
                ExpiredDate: card.dataset.expiredDate,
                BinID: (binID == "" || binID == null) ? null : parseFloat(binID),
                BinQty: (binQtyValue == "" || binQtyValue == null) ? null : parseFloat(binQtyValue),
                isModified: "true"
            })
        }
        else {
            card.classList.remove("bg-warning");
            card.classList.add("bg-light");
            $binSelect.val(null).trigger("change")
            binQty.value = ""
            //// Unselecting the card - change back to light/gray
            //card.classList.remove("bg-warning", "text-dark");
            
            //// Update parent card classes
            //parentCard.classList.remove("bg-warning", "text-dark");
            
            //// Log for debugging (can be removed in production)
            //if (darkTheme) {
            //    console.log('Dark theme detected - Card unselected:', card.dataset.itemId);
            //}
            //else{
            //    //card.classList.add("bg-light");
            //    //parentCard.classList.add("bg-light", "batch-card-new");

            //}
            
            //const selectElement = card.querySelector("select");
            //if (selectElement && selectElement.options[0]) {
            //    selectElement.options[0].text = ""
            //}
            
            //card.querySelector("select").options[0].text = ""
            webControls.forEach(input => {
                input.setAttribute("disabled", true)
                //input.value = ""
            }
            );
            ItemList = ItemList.filter(item =>
                !(item.ItemID === card.dataset.itemId
                    && item.NIE_BPOM === card.dataset.nieBpom
                    && item.BatchID === card.dataset.batchId
                    && item.ExpiredDate === card.dataset.expiredDate)
            );
        }
        card.dataset.isModified = isModified ? "false" : "true";
    }
}
function LoadFailSavedData() {
    if (ViewMode) return
    
    let JsonData = $("#toolbarData").val()
    if (JsonData) {
        try {
            const parsedData = JSON.parse(JsonData)
            parsedData.forEach(data => {
                let card = document.querySelector(`.card-body[data-item-id="${data.ItemID}"][data-nie-bpom="${data.NIE_BPOM}"][data-batch-id="${data.BatchID}"][data-expired-date="${data.ExpiredDate}"][data-is-open="false"]`);
                if (card) {
                    card.classList.remove("bg-warning")
                    card.classList.add("bg-light")
                    card.dataset.isModified = "true"
                    ItemList.push({
                        ItemID: data.ItemID,
                        NIE_BPOM: data.NIE_BPOM,
                        BatchID: data.BatchID,
                        ExpiredDate: data.ExpiredDate
                    })
                }
            })
        } catch (error) {
            Swal.fire({
                icon: 'warning',
                title: 'JSON Error',
                text: 'Failed to save: Please contact IT Department',
                confirmButtonText: 'OK'
            });
        }
    }
}
function ReadScanner(element, code) {
    let found = false;
    let barcodeScan = code.length <= 40 ? code : code.substring(0, 40);
    let searchTextBox = document.getElementById("searchComponent")
    if (searchTextBox) {
        searchTextBox.value = barcodeScan
        searchTextBox.dispatchEvent(new KeyboardEvent('keypress', {
            key: 'Enter',
            which: 13,
            keyCode: 13,
            bubbles: true
        }));
    }
}
function onEditConfirmed(event) {
    const radioSelection = document.querySelectorAll(".radio-selection")
    let isTransactionProceed = document.querySelector("input[name='isTransactionProceed']")?.value
    let selectionType = "Location";
    let locationID = null;
    let transactionNo = null;

    radioSelection.forEach(radio => {
        if (radio.checked) {
            selectionType = radio.value;
            if (radio.value == "Location") {
                let selectedLocation = document.getElementById("selectLocation");
                if (!selectedLocation || !selectedLocation.value || selectedLocation.value === "" || selectedLocation.value === "-- Select Location --") {
                    event.preventDefault()
                    Swal.fire({
                        icon: "warning",
                        title: "Location",
                        text: "Please choose Location",
                        allowEscapeKey: false,
                        allowOutsideClick: false,
                        timer: 5000,
                        showConfirmButton: true
                    });
                    return;
                }
                locationID = selectedLocation.value;
            }
            else if (radio.value == "TransactionNo")
            {
                let TransNo = document.getElementById("transactionNoField");
                if (!TransNo || !TransNo.value || TransNo.value === "") {
                    event.preventDefault()
                    Swal.fire({
                        icon: "warning",
                        title: "TransactionNo Error",
                        text: "Please enter TransactionNo",
                        allowEscapeKey: false,
                        allowOutsideClick: false,
                        timer: 5000,
                        showConfirmButton: true
                    });
                    return;
                }
                transactionNo = TransNo.value;
            }
        }
    })

    if (selectionType == "TransactionNo" && isTransactionProceed && isTransactionProceed == "true") {
        event.preventDefault()
        Swal.fire({
            icon: "warning",
            title: "Transaction Complete",
            text: "This Transaction has been proceed",
            allowEscapeKey: false,
            allowOutsideClick: false,
            timer: 5000,
            showConfirmButton: true
        });
        return;
    }

    const searchComponent = document.getElementById("searchComponent");
    const searchQuery = searchComponent ? searchComponent.value : "";

    //dataToSend = document.getElementById("selectLocation").value
    dataToSend = {
        SelectionType: selectionType,
        LocationID: locationID,
        TransactionNo: transactionNo,
        SearchQuery: searchQuery
    };
}
function onCancelConfirmed() {
    //dataToSend = document.getElementById("selectedLocation").dataset.locid
    let locationID = document.getElementById("selectedLocation")?.dataset.locid || null;
    let selectionType = document.querySelector("input[type='hidden'][name='SelectionType']")?.value || "Location";
    let transactionNo = document.querySelector("input[type='hidden'][name='TransactionNo']")?.value || null;
    const searchComponent = document.getElementById("searchComponent");
    const searchQuery = searchComponent ? searchComponent.value : "";

    dataToSend = {
        SelectionType: selectionType,
        LocationID: locationID,
        TransactionNo: transactionNo,
        SearchQuery: searchQuery
    };
}
function assignDataToSend() {
    if (!ItemList || ItemList.length === 0) {
        Swal.fire({
            icon: "warning",
            title: "No Data",
            showConfirmButton: true
        });
        return false;
    }

    var binEmptyList = []

    for (const a of ItemList) {
        if (a.BinID == null || a.BinID == "") {
            binEmptyList.push(a.ItemID);
        }
    }

    if (binEmptyList.length > 0) {
        Swal.fire({
            icon: "error",
            title: "Bin Not Chosen",
            text: `Please choose bin for: ${binEmptyList.join(", ")}`,
            allowEscapeKey: false,
            allowOutsideClick: false,
            timer: 5000,
            showConfirmButton: true
        });
        return false;
    }
    let selectionType = document.querySelector("input[type='hidden'][name='SelectionType']")?.value
    let transactionNo = document.querySelector("input[type='hidden'][name='TransactionNo']")?.value
    let seletedLocation = document.getElementById("selectedLocation").dataset.locid
    const searchComponent = document.getElementById("searchComponent");
    const searchQuery = searchComponent ? searchComponent.value : "";

    dataToSend = {
        SelectionType: selectionType,
        LocationID: seletedLocation,
        TransactionNo: transactionNo,
        ItemDetailViewModel: ItemList,
        SearchQuery: searchQuery
    };
    return true;
}

// #region Select2
// Initialize Select2 for Bin Location dropdowns
const initializeBinSelects = () => {
    $('.bin-select').each(function () {
        if (!$(this).hasClass('select2-hidden-accessible')) {
            $(this).select2({
                placeholder: $(this).data('placeholder') || '-- Select Bin --',
                allowClear: false,
                width: '100%',
                theme: 'bootstrap-5',
                dropdownParent: $(this).closest('.card-body'),
                language: {
                    noResults: function () {
                        return 'No bins found';
                    },
                    searching: function () {
                        return 'Searching...';
                    }
                }
            });

            // Auto-focus on search box when dropdown opens (Desktop & Mobile)
            $(this).on('select2:open', function (e) {
                // Small delay to ensure dropdown is rendered
                setTimeout(function () {
                    // Find the search input in the dropdown
                    const searchField = document.querySelector('.select2-search__field');
                    if (searchField) {
                        searchField.focus();
                    }
                }, 50);
            });

            // Trigger original onchange event when selection changes
            $(this).on('select2:select', function (e) {
                if (typeof SelectedBin === 'function') {
                    SelectedBin(this);
                }
            });
        }
    });
};

// Setup MutationObserver for dynamic content
const setupBinSelectObserver = () => {
    const collectionContainer = document.getElementById('collectionContainer');
    if (!collectionContainer) {
        console.warn('collectionContainer not found. Observer not initialized.');
        return;
    }

    let initTimer;
    const observer = new MutationObserver(function (mutations) {
        clearTimeout(initTimer);
        initTimer = setTimeout(() => {
        mutations.forEach(function (mutation) {
            if (mutation.addedNodes.length > 0) {
                initializeBinSelects();
            }
        });
        }, 300); // Delay to batch multiple mutations
    });

    observer.observe(collectionContainer, {
        childList: true,
        subtree: true
    });
};
// #endregion

// #region Search (Client-Side) (Not Used)
//async function performSearch(searchQuery) {
//    let selectionType = document.querySelector("input[type='hidden'][name='SelectionType']")?.value
//    let collectionContainerDiv = document.getElementById("collectionContainer")
//    if (collectionContainerDiv) {
//        collectionContainerDiv.innerHTML = ""
//    }

//    // Escape regex unsafe characters
//    function escapeRegExp(string) {
//        return string.replace(/[.*+?^${}()|[\]\\]/g, '\\$&');
//    }

//    let searchResult = []
//    if (originalData.length > 0) {
//        originalData.forEach(item => {
//            if (!searchQuery) {
//                searchResult = originalData;
//            }
//            else {
//                if (searchQuery.length >= 30) {
//                    searchResult = originalData.filter(item =>
//                        item.Barcode && item.Barcode.toLowerCase().includes(searchQuery.toLowerCase())
//                    )
//                }
//                else {
//                    searchResult = originalData.filter(item =>
//                        item.ItemID.toLowerCase().includes(searchQuery.toLowerCase())
//                        || item.NIE_BPOM.toLowerCase().includes(searchQuery.toLowerCase())
//                        || item.BatchID.toLowerCase().includes(searchQuery.toLowerCase())
//                        || item.ItemName.toLowerCase().includes(searchQuery.toLowerCase())
//                        || (item.BinName ?? "").toLowerCase().includes(searchQuery.toLowerCase())
//                    )
//                }
//            }
//        })

//        let safeQuery = searchQuery ? escapeRegExp(searchQuery) : null;
//        let highlightRegex = safeQuery ? new RegExp(`(${safeQuery})`, "gi") : null;

//        // Use DocumentFragment for better performance
//        const fragment = document.createDocumentFragment();

//        // Render in batches to avoid blocking UI
//        const batchSize = 20; // Render 20 items at a time

//        for (let i = 0; i < searchResult.length; i += batchSize) {
//            const batch = searchResult.slice(i, i + batchSize);

//            // Render batch
//            batch.forEach(item => {
//                const colDiv = createCardElement(item, searchQuery, highlightRegex, selectionType);
//                fragment.appendChild(colDiv);
//            });

//            // Append to DOM
//            collectionContainerDiv.appendChild(fragment.cloneNode(true));

//            // Clear fragment for next batch
//            while (fragment.firstChild) {
//                fragment.removeChild(fragment.firstChild);
//            }

//            // Yield to browser to keep UI responsive
//            if (i + batchSize < searchResult.length) {
//                await new Promise(resolve => requestAnimationFrame(resolve));
//            }
//        }        
//    }
//}
//function createCardElement(item, searchQuery, highlightRegex, selectionType) {
//    //Create Partial View
//    //searchResult.forEach(item => {
//        var colDiv = document.createElement("div")
//        colDiv.className = "col"

//        var cardClass = (item.BinQty > 0 && item.isOpen == false)
//            ? "card h-100 shadow-sm bg-danger text-white card-lock"
//            : (item.isOpen == false ? "card h-100 shadow-sm bg-light" : "card h-100 shadow-sm bg-primary text-white")
//        var cardDiv = document.createElement("div")
//        cardDiv.className = cardClass

//        var cardbodyDiv = document.createElement("div")
//        cardbodyDiv.className = "card-body card-clickable"
//        cardbodyDiv.dataset.isOpen = item.isOpen.toString().toLowerCase()
//        cardbodyDiv.dataset.isModified = "false"
//        cardbodyDiv.dataset.cf = item.ConvertionFactor
//        cardbodyDiv.dataset.itemId = item.ItemID
//        cardbodyDiv.dataset.nieBpom = item.NIE_BPOM
//        cardbodyDiv.dataset.batchId = item.BatchID
//        cardbodyDiv.dataset.expiredDate = item.ExpiredDate
//        cardbodyDiv.dataset.balance = item.Balance
//        cardbodyDiv.dataset.barcode = item.Barcode?.length >= 40 ? item.Barcode.substring(0, 40) : item.Barcode

//        // Check if this item is in ItemList (previously selected)
//        if (ItemList.some(data =>
//            item.isOpen == false
//            && data.ItemID == item.ItemID
//            && data.NIE_BPOM == item.NIE_BPOM
//            && data.BatchID == item.BatchID
//            && data.ExpiredDate == item.ExpiredDate
//        )) {
//            cardbodyDiv.dataset.isModified = "true"
//            cardDiv.classList.remove("bg-light");
//            cardDiv.classList.add("bg-warning");
//        }

//        // Add click handler
//        if (!(item.BinQty > 0 && item.isOpen == false)) {
//            cardbodyDiv.addEventListener('click', function (e) {
//                const tag = e.target.tagName.toLowerCase();
//                if (['select', 'input', 'option', 'button'].includes(tag)) return;
//                OpenBatch(this);
//            });
//        }
//        //else {
//        //    cardbodyDiv.addEventListener('click', function (e) {
//        //        if (ViewMode) return;
//        //        Swal.fire({
//        //            icon: "warning",
//        //            title: "Bin Lock",
//        //            text: "Please Unlock bin from Bin Stock",
//        //            allowEscapeKey: false,
//        //            allowOutsideClick: false,
//        //            timer: 5000,
//        //            showConfirmButton: true
//        //        });
//        //    });
//        //}

//        //Add H5
//        var itemName = document.createElement("h5")
//        itemName.className = "card-title fw-bold"
//        //itemName.innerHTML = searchQuery ? item.ItemName.replace(new RegExp(`(${searchQuery})`, "gi"), "<mark>$1</mark>")
//        //    : item.ItemName
//        itemName.innerHTML = searchQuery ? item.ItemName.replace(highlightRegex, "<mark>$1</mark>")
//            : item.ItemName
//        cardbodyDiv.appendChild(itemName)

//        //Add ul
//        var ul = document.createElement("ul")
//        ul.className = "list-unstyled mb-0"

//        //Add li
//        let newLi = (label, value) => {
//            //let displayValue = value?.toString() ?? ""
//            //if (searchQuery) {
//            //    let regex = new RegExp(`(${searchQuery})`, "gi")
//            //    displayValue = displayValue.replace(regex, "<mark>$1</mark>")
//            //}
//            let displayValue = value?.toString() ?? "";
//            if (searchQuery && highlightRegex) {
//                displayValue = displayValue.replace(highlightRegex, "<mark>$1</mark>");
//            }
//            let list = document.createElement("li")
//            list.innerHTML = `<strong>${label}</strong> ${displayValue}`
//            return list
//        }

//        let itemTotal = originalData
//            .filter(x => x.ItemID === item.ItemID)
//            .reduce((sum, x) => sum + (x.Balance ?? 0), 0);

//        ul.appendChild(newLi("🆔 ItemID:", item.ItemID))
//        ul.appendChild(newLi("🆔📊 Item Total:", itemTotal))
//        ul.appendChild(newLi("🔖 NIE BPOM:", item.NIE_BPOM))
//        ul.appendChild(newLi("📦 Batch:", item.BatchID))
//        ul.appendChild(newLi("📅 Expired:", item.ExpiredDate ?? ""))
//        if (selectionType == "Location") {
//            ul.appendChild(newLi("📊 Balance:", item.Balance ?? 0))
//        }
//        else {
//            ul.appendChild(newLi("📊 Qty:", `${item.Balance ?? 0} (${item.SRUnit})`))
//            ul.appendChild(newLi("📊 Qty (Max):", `${item.Balance ?? 0 * item.ConvertionFactor ?? 0} (${item.SRItemUnit})`))
//        }

//        if (!ViewMode) {
//            if (selectionType == "Location") {
//                ul.appendChild(newLi("🗄️ Bin:", item.BinQty))
//            }
//        } else {
//            let binText = item.BinQty;
//            if (item.BinName && item.BinName.trim() !== "") {
//                binText += ` [${item.BinName}]`;
//            }
//            ul.appendChild(newLi("🗄️ Bin:", binText))
//        }

//        ul.appendChild(newLi("Barcode:", item.Barcode ?? ""))
//        cardbodyDiv.appendChild(ul)

//        // Add Edit Mode Controls (Bin Location, Qty, Buttons)
//        if (!ViewMode) {
//            var editControlsDiv = document.createElement("div")
//            editControlsDiv.className = "mt-3"

//            // Check if this item exists in ItemList (user's previous selections)
//            const existingItem = ItemList.find(data =>
//                data.ItemID === item.ItemID
//                && data.NIE_BPOM === item.NIE_BPOM
//                && data.BatchID === item.BatchID
//                && data.ExpiredDate === item.ExpiredDate
//            );
//            cardbodyDiv.dataset.isModified = existingItem?.isModified ?? "false"

//            // Bin Location Label
//            var binLabel = document.createElement("label")
//            binLabel.className = "form-label " + (item.isOpen ? "text-white" : "text-black")
//            binLabel.textContent = "Bin Location:"
//            editControlsDiv.appendChild(binLabel)

//            // Bin Location Select
//            var binSelect = document.createElement("select")
//            binSelect.className = "form-select form-select-sm"
//            binSelect.name = "BinTarget"
//            binSelect.onchange = function () { SelectedBin(this) }

//            // Disable if not open or already has BinID
//            if (!item.isOpen || (item.BinID != null && item.BinID > 0)) {
//                binSelect.disabled = true
//            }

//            // Add default option
//            var defaultOption = document.createElement("option")
//            defaultOption.value = ""
//            defaultOption.textContent = (item.isOpen || existingItem?.isModified == "true") ? "-- Select Bin --" : ""
//            binSelect.appendChild(defaultOption)

//            // Add bin options from originalData or global bin list
//            // Note: We need to get ItemBin from the model - for now using empty check
//            // This should ideally come from Model.ItemBin passed to JavaScript
//            if (ItemBinList && ItemBinList.length > 0) {
//                ItemBinList.forEach(bin => {
//                    var option = document.createElement("option")
//                    option.value = bin.BinID
//                    option.textContent = bin.BinName

//                    // Restore previously selected bin from ItemList
//                    if (existingItem && bin.BinID == existingItem.BinID) {
//                        option.selected = true
//                    } else if (bin.BinID == item.BinID) {
//                        option.selected = true
//                    }
//                    binSelect.appendChild(option)
//                })
//            }

//            editControlsDiv.appendChild(binSelect)

//            if (selectionType == "TransactionNo") {
//                var binQtyDisplay = document.createElement("div")
//                binQtyDisplay.className = "ms-3 mt-2"

//                var binQtyLabel = document.createElement("label")
//                binQtyLabel.innerHTML = `<strong>🗄️ Bin:</strong> ${item.BinQty}`

//                binQtyDisplay.appendChild(binQtyLabel)
//                editControlsDiv.appendChild(binQtyDisplay)
//            }

//            // Qty Label
//            var qtyLabel = document.createElement("label")
//            qtyLabel.className = "form-label mt-2 " + (item.isOpen ? "text-white" : "text-black")
//            qtyLabel.textContent = "Qty:"
//            editControlsDiv.appendChild(qtyLabel)

//            // Qty Input
//            var qtyInput = document.createElement("input")
//            qtyInput.type = "number"
//            qtyInput.id = `input-${item.ItemID}-${item.NIE_BPOM}-${item.BatchID}`
//            qtyInput.className = "form-control form-control-sm"
//            qtyInput.inputMode = "numeric"
//            if (selectionType == "Location") {
//                qtyInput.max = Math.max(0, (item.Balance ?? 0) - (item.BinQty ?? 0))
//            }
//            else {
//                var TransNoMaxInput = item.SRUnit == item.SRItemUnit ? (item.Balance ?? 0) : ((item.Balance ?? 0) * (item.ConvertionFactor ?? 0))
//                qtyInput.max = Math.max(0, TransNoMaxInput)
//            }
//            qtyInput.min = 0
//            qtyInput.onchange = function () { MaxQty(this) }

//            if (!item.isOpen) {
//                qtyInput.disabled = true
//            }
//            // Restore previously entered quantity from ItemList
//            if (existingItem && existingItem.BinQty != null) {
//                qtyInput.value = existingItem.BinQty
//                qtyInput.disabled = false
//            }

//            if (existingItem?.isModified == "true") {
//                binSelect.disabled = false
//            }

//            editControlsDiv.appendChild(qtyInput)

//            cardbodyDiv.appendChild(editControlsDiv)

//            // Add CF Buttons if applicable
//            if (item.BinQty <= 0 || item.isOpen) {
//                var buttonContainer = document.createElement("div")
//                buttonContainer.className = "d-flex justify-content-center gap-2"

//                // Add Button
//                var btnAdd = document.createElement("button")
//                btnAdd.type = "button"
//                btnAdd.className = "btn btn-success btn-sm mt-3"
//                btnAdd.id = `btnAdd-${item.ItemID}-${item.NIE_BPOM}-${item.BatchID}`
//                btnAdd.textContent = "+ (CF)"
//                btnAdd.onclick = function () { AddReduceCF(this, 'add', item.ConvertionFactor) }
//                if (!item.isOpen) {
//                    btnAdd.disabled = true
//                }
//                // Restore previously entered quantity from ItemList
//                if (existingItem && existingItem.BinQty != null) {
//                    btnAdd.disabled = false
//                }
//                buttonContainer.appendChild(btnAdd)

//                // Reduce Button
//                var btnReduce = document.createElement("button")
//                btnReduce.type = "button"
//                btnReduce.className = "btn btn-danger btn-sm mt-3"
//                btnReduce.id = `btnReduce-${item.ItemID}-${item.NIE_BPOM}-${item.BatchID}`
//                btnReduce.textContent = "- (CF)"
//                btnReduce.onclick = function () { AddReduceCF(this, 'reduce', item.ConvertionFactor) }
//                if (!item.isOpen) {
//                    btnReduce.disabled = true
//                }
//                // Restore previously entered quantity from ItemList
//                if (existingItem && existingItem.BinQty != null) {
//                    btnReduce.disabled = false
//                }
//                buttonContainer.appendChild(btnReduce)

//                cardbodyDiv.appendChild(buttonContainer)

//                // CF Display
//                var cfDisplay = document.createElement("small")
//                cfDisplay.className = "d-block text-end pt-2 " + (item.isOpen ? "text-white" : "text-black")
//                cfDisplay.textContent = `CF: ${item.ConvertionFactor}`
//                cardbodyDiv.appendChild(cfDisplay)
//            }

//        }

//        cardDiv.appendChild(cardbodyDiv)
//        colDiv.appendChild(cardDiv)
//        return colDiv;

//    //    collectionContainerDiv.appendChild(colDiv)
//    //})
//}
// #endregion

//If fail parsing JSON data from SaveButton, then restore previous state
//$(document).ready(function () {
//    if (ViewMode) return
//    let JsonData = $("#toolbarData").val()
//    if (JsonData) {
//        try {
//            const parsedData = JSON.parse(JsonData)
//            parsedData.forEach(data => {
//                let card = document.querySelector(`.card-body[data-item-id="${data.ItemID}"][data-nie-bpom="${data.NIE_BPOM}"][data-batch-id="${data.BatchID}"][data-expired-date="${data.ExpiredDate}"][data-is-open="false"]`);
//                if (card) {
//                    card.classList.remove("bg-warning")
//                    card.classList.add("bg-light")
//                    card.dataset.isModified = "true"
//                    dataToSend.push({
//                        ItemID: data.ItemID,
//                        NIE_BPOM: data.NIE_BPOM,
//                        BatchID: data.BatchID,
//                        ExpiredDate: data.ExpiredDate
//                    })
//                }
//            })
//        } catch (error) {
//            Swal.fire({
//                icon: 'warning',
//                title: 'JSON Error',
//                text: 'Failed to save: Please contact IT Department',
//                confirmButtonText: 'OK'
//            });
//        }
//    }
//});