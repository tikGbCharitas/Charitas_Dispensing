document.addEventListener("DOMContentLoaded", function () {
    const addBinButton = document.getElementById("btnNewBin");
    if (addBinButton) {
        addBinButton.addEventListener("click", CreateNewBin)
    }

    const collapseAddBin = document.getElementById("collapseAddBin")
    if (collapseAddBin) {
        collapseAddBin.addEventListener("show.bs.collapse", CollapseBin)
    }

    attachCardEventListeners();
    
    const downloadPdfBtn = document.getElementById("downloadPdfBtn")
    if (downloadPdfBtn) {
        downloadPdfBtn.addEventListener("click", exportQRToPDF)
    }

    const generateMultipleQRCodeContainer = document.getElementById("generateMultipleQRCode")
    if (generateMultipleQRCodeContainer) {
        generateMultipleQRCodeContainer.addEventListener("click", generateMultipleQRCode)
    }

    const deleteMultipleBinsBtn = document.getElementById("deleteMultipleBins")
    if (deleteMultipleBinsBtn) {
        deleteMultipleBinsBtn.addEventListener("click", deleteMultipleBins)
    }

    const chkAllBinsControl = document.getElementById("chkAllBinsControl")
    if (chkAllBinsControl) {
        chkAllBinsControl.addEventListener("click", chkAllBins)
    }

    $("#searchComponent").on("keydown", searchFunction);

    $("#searchButton").on("click", function () {
        const searchQuery = $("#searchComponent").val() || "";
        performAjaxSearch(searchQuery);
    });

    // Add click handler for clear button
    $("#clearSearchButton").on("click", clearSearch);

    updateSearchResultInfo($("#collectionContainer").find('.card').length);
})

const strings = window.LocalizedStrings || {};

function CollapseBin(event) {
    let SelectedLocation = document.getElementById("selectLocation")
    if (SelectedLocation) {
        let selected = SelectedLocation.value;
        if (!selected || selected == "" || selected.value === "-- Select Location --" || selected.value === "-- Pilih Lokasi --") {
            event.preventDefault()
            Swal.fire({
                icon: "warning",
                title: strings.location || "Location",
                text: strings.pleaseChooseLocation || "Please choose Location",
                allowEscapeKey: false,
                allowOutsideClick: false,
                timer: 5000,
                showConfirmButton: true
            });
            return;
        }
    }
}

function CreateNewBin(event) {
    let rejectedBinName = [];
    let binUserInputContainer = document.getElementById("BinName")
    let binUserInputValue = binUserInputContainer.value
    let binCollection = binUserInputValue.split(";").map(a => a.trim()).filter(a => a != "")
    let LocID = document.getElementById('selectLocation').value

    if (binCollection.length < 1) {
        event.preventDefault()
        Swal.fire({
            icon: 'error',
            title: strings.binNameError || 'Bin Name Error',
            text: strings.binNameCannotBeEmpty || `Bin Name cannot be empty`,
            allowOutsideClick: false,
            allowEscapeKey: false,
            showConfirmButton: true,
            timer: 5000
        });
        return
    }

    binCollection.forEach(a => {
        if (a.trim().length > 10) {
            rejectedBinName.push(a)
        }
        else if (!/^[A-Za-z][A-Za-z0-9\s-]*$/.test(a)) {
            rejectedBinName.push(a);
        }
    })

    if (rejectedBinName.length > 0) {
        event.preventDefault()
        Swal.fire({
            icon: 'error',
            title: strings.binNameError || 'Bin Name Error',
            html: (strings.binNameTooLong || 'Bin Name cannot more than 10 Char(s) and must start with [A-Z/a-z]') + ` <br><strong>${rejectedBinName.join(";<br>").replaceAll(";", ",")}</strong>`,
            allowOutsideClick: false,
            allowEscapeKey: false,
            showConfirmButton: true,
            timer: 5000
        });
        return
    }

    Swal.fire({
        title: strings.processing || 'Processing...',
        text: strings.pleaseWait || 'Please wait while we create bins.',
        allowOutsideClick: false,
        allowEscapeKey: false,
        didOpen: () => {
            Swal.showLoading();
        }
    });

    var token = $('input[name="__RequestVerificationToken"]').val()

    $.ajax({
        url: AddBinUrl,
        type: "POST",
        headers: {
            'RequestVerificationToken': token
        },
        contentType: "application/json",
        data: JSON.stringify({
            LocID: LocID,
            Coll: binCollection
        }),
        success: function (response) {
            if (response.success) {
                if (response.data.saved.length > 0 && response.data.exist.length > 0) {
                    Swal.fire({
                        icon: 'success',
                        title: strings.binCreated || 'Bin Created',
                        html: `Bin(s) <strong>${response.data.saved.join(", ")}</strong> ${strings.binCreatedSuccessfully || 'created successfully!'}!<br>
                             Bin(s) <strong>${response.data.exist.join(", ")}</strong> ${strings.alreadyExist || 'already EXIST'} <br>
                             Bin(s) <strong>${response.data.duplicate.join(", ")}</strong>.`,
                        allowOutsideClick: false,
                        allowEscapeKey: false,
                        showConfirmButton: true,
                        timer: 5000
                    }).then(() => {
                        window.location.href = response.redirect;
                    });
                }
                else if (response.data.saved.length > 0 && response.data.exist.length == 0) {
                    Swal.fire({
                        icon: 'success',
                        title: strings.binCreated || 'Bin Created',
                        html: `Bin(s) <strong>${response.data.saved.join(", ")}</strong> ${strings.binCreatedSuccessfully || 'created successfully!'}!`,
                        allowOutsideClick: false,
                        allowEscapeKey: false,
                        showConfirmButton: true,
                        timer: 5000
                    }).then(() => {
                        window.location.href = response.redirect;
                    });
                }
                else {
                    Swal.close();
                    Swal.fire({
                        icon: 'info',
                        title: strings.binExist || 'Bin Exist',
                        html: `Bin(s) <strong>${response.data.exist.join(", ")}</strong> ${strings.alreadyExist || 'already EXIST'}.`,
                        allowOutsideClick: false,
                        allowEscapeKey: false,
                        showConfirmButton: true,
                        timer: 5000
                    })
                }
            }            
        },
        error: function (xhr, status, error) {
            Swal.close();
            Swal.fire({
                icon: 'error',
                title: strings.errorCreatingBin || 'Error Creating Bin',
                text: `${strings.errorOccurredCreatingBin || 'An error occurred while creating the bin(s):'} ${xhr.responseText}`,
                allowOutsideClick: false,
                allowEscapeKey: false,
                showConfirmButton: true,
                timer:5000
            });
        }
    })
}

function chkAllBins(event) {
    const isChecked = event.target.value
    const chkAllControl = document.querySelectorAll(".bin-checkbox")
    const inputQRCode = document.getElementById("MultipleSelectionInputControl")
    inputQRCode.value = ''

    switch (isChecked) {
        case "0":
            chkAllControl.forEach(chk => {
                chk.checked = true;
                chk.dispatchEvent(new Event("change"))
            })
            event.target.value = 1;
            event.target.textContent = "Deselect All"
            event.target.classList.add("bg-success", "text-white")
            break;
        case "1":
            chkAllControl.forEach(chk => {
                chk.checked = false;
            })
            event.target.value = 0;
            event.target.textContent = "Select All"
            event.target.classList.remove("bg-success", "text-white")
    }
}
//function searchFunction(event) {
//    //var userInput = event.target.value.trim();
//    //const binNameColl = document.querySelectorAll(".bin-name-input")

//    //if (!userInput) {
//    //    binNameColl.forEach(bin => {
//    //        let binContainer = bin.parentElement.parentElement.parentElement.parentElement;
//    //        binContainer.classList.remove("d-none")
//    //    })
//    //    return;
//    //}

//    //binNameColl.forEach(bin => {
//    //    let binName = bin.value.trim().toLowerCase();
//    //    let binContainer = bin.parentElement.parentElement.parentElement.parentElement;
//    //    if (binName.includes(userInput.toLowerCase())) {
//    //        binContainer.classList.remove("d-none")
//    //    }
//    //    else{
//    //        binContainer.classList.add("d-none")
//    //    }
//    //})

//    if (event.key === 'Enter' || event.which === 13) {
//        event.preventDefault();
//        const searchQuery = $(event.target).val() || "";
//        performAjaxSearch(searchQuery);
//    }
//}
function generateQRCode(event) {
    const modalBody = document.getElementById("barcodeModalBody");
    modalBody.innerHTML = "";
    const barcodeSpacingContainer = document.getElementById("barcodeModalFooter").querySelector(".qr-code-spacing")
    barcodeSpacingContainer.classList.add("d-none")

    const binName = event.target.parentElement.parentElement.querySelector('.bin-name-input').value.trim()

    const qrWrapper = document.createElement("div");
    qrWrapper.classList.add("d-flex", "flex-column", "align-items-center", "qr-canvas");

    const qrBox = document.createElement("div");
    new QRCode(qrBox, {
        text: binName,
        width: 160,
        height: 160
    });

    const modalTitle = document.getElementById("barcodeModalTitle");
    modalTitle.textContent = binName

    qrWrapper.appendChild(qrBox);
    modalBody.appendChild(qrWrapper);

    const modal = new bootstrap.Modal(document.getElementById("barcodeModal"))
    modal.show();
}

function GeneratBinNameBarcode(event) {
    const input = document.getElementById("MultipleSelectionInputControl")
    const binName = event.target.parentElement.querySelector(".bin-name-input").value.trim()
    const isChecked = event.target.checked
    if (isChecked) {
        if (!input.value.includes(binName)) {
            input.value += `${binName}; `;
        }    }
    else {
        let names = input.value.split(";").map(n => n.trim()).filter(n => n !== "");

        names = names.filter(n => n !== binName);
        input.value = names.join("; ") + (names.length > 0 ? "; " : "");
    }
}

function generateMultipleQRCode(event) {
    const modalBody = document.getElementById("barcodeModalBody");
    modalBody.innerHTML = "";

    const userInput = event.target.parentElement.querySelector('#MultipleSelectionInputControl')
    const text = userInput.value.trim();

    if (!text) {
        Swal.fire({
            icon: 'error',
            title: 'Bin Name Error',
            text: `Bin Name cannot be empty`,
            allowOutsideClick: false,
            allowEscapeKey: false,
            showConfirmButton: true,
            timer: 5000
        });
        return;
    }
    const barcodeSpacingContainer = document.getElementById("barcodeModalFooter").querySelector(".qr-code-spacing")
    barcodeSpacingContainer.classList.remove("d-none")

    let rejectedBins = [];

    const modalTitle = document.getElementById("barcodeModalTitle");
    modalTitle.textContent = "Multiple QR Code"

    let binNameColl = text.split(";").map(a => a.trim()).filter(a => a !== "")
    binNameColl.forEach(bin => {
        if (bin.length > 10) {
            rejectedBins.push(bin);
            return; // continue to next iteration
        }

        const qrWrapper = document.createElement("div");
        qrWrapper.classList.add("d-flex", "flex-column", "align-items-center", "m-3", "qr-canvas");

        const qrBox = document.createElement("div");
        new QRCode(qrBox, {
            text: bin,
            width: 160,
            height: 160
        });

        const label = document.createElement("div");
        label.textContent = bin;
        label.classList.add("mt-2", "modal-bin-name");

        qrWrapper.appendChild(qrBox);
        qrWrapper.appendChild(label);
        modalBody.appendChild(qrWrapper);
    });

    if (rejectedBins.length > 0) {
        Swal.fire({
            icon: 'warning',
            title: 'Rejected Bin',
            html: `<strong>Reason:</strong> Exceeds 10 characters<br><br><ul style="text-align:left">${rejectedBins.map(bin => `<li>${bin}</li>`).join('')}</ul>`,
        });
    }

    const modal = new bootstrap.Modal(document.getElementById('barcodeModal'))
    modal.show();
}

function exportQRToPDF(event) {
    const barcodeSize = document.getElementById("qrCodeSize").value;
    const isValidNumber = /^[0-9]+(\.[0-9]+)?$/.test(barcodeSize.trim());
    if (!isValidNumber) {
        Swal.fire({
            icon: "warning",
            title: "Invalid Size",
            text: "Please enter a valid number",
            allowEscapeKey: false,
            allowOutsideClick: false,
            timer: 5000,
            showConfirmButton: true
        });
        return
    }

    const modalContainer = document.getElementById("barcodeModal");
    const paperSize = document.getElementById("paperSize").value
    const paperOrientation = document.getElementById("paperOrientation").value
    const { jsPDF } = window.jspdf;
    const pdf = new jsPDF({
        orientation: paperOrientation,
        unit: "mm",
        format: paperSize
    })

    const pageWidth = pdf.internal.pageSize.getWidth();
    const pageHeight = pdf.internal.pageSize.getHeight();
    const qrSizeMM = Number(barcodeSize); // QR size on PDF (mm)
    const margin = 10;
    const pdfFontSize = 8;
    const pdfFontSpacing = 5;
    var xLoc = margin;
    var yLoc = margin;
    const labelHeight = pdfFontSize * 0.3528 + 2;

    const qrCanvases = modalContainer.querySelectorAll(".qr-canvas")
    if (qrCanvases.length == 1) {
        const binName = modalContainer.querySelector('#barcodeModalTitle').textContent.trim();
        const imgData = qrCanvases[0].querySelector('canvas').toDataURL(`image/png`);
        pdf.addImage(imgData, "PNG", xLoc, yLoc, qrSizeMM, qrSizeMM);

        pdf.setFontSize(pdfFontSize);
        pdf.text(binName, xLoc + qrSizeMM / 2, yLoc + qrSizeMM + pdfFontSpacing, { align: "center" });

        pdf.save(`${binName}_QRCode.pdf`);
    }
    else {
        const barcodeSpacing = modalContainer.querySelector('#qrCodeSpacing').value;
        const isBarcodeSpacingValid = /^[0-9]+(\.[0-9]+)?$/.test(barcodeSpacing.trim())
        if (!isBarcodeSpacingValid) {
            Swal.fire({
                icon: "warning",
                title: "Invalid Size",
                text: "Please enter a valid number",
                allowEscapeKey: false,
                allowOutsideClick: false,
                timer: 5000,
                showConfirmButton: true
            });
            return
        }

        const spacing = Number(barcodeSpacing);
        qrCanvases.forEach(canvas => {
            const binName = canvas.querySelector('.modal-bin-name').textContent.trim()
            const imgData = canvas.querySelector('canvas').toDataURL(`image/png`);

            if (yLoc + qrSizeMM + labelHeight + margin > pageHeight) {
                pdf.addPage();
                xLoc = margin;
                yLoc = margin;
            }

            pdf.addImage(imgData, "PNG", xLoc, yLoc, qrSizeMM, qrSizeMM);

            pdf.setFontSize(pdfFontSize);
            pdf.text(binName, xLoc + qrSizeMM / 2, yLoc + qrSizeMM + pdfFontSpacing, { align: "center" });

            xLoc += qrSizeMM + spacing;

            if (xLoc + qrSizeMM + margin > pageWidth) {
                xLoc = margin;
                yLoc += qrSizeMM + pdfFontSpacing + labelHeight + spacing
            }
        })

        const pdfName = new Date().toISOString().slice(0, 10)
        pdf.save(`${pdfName}_QRCode.pdf`);
    }
}

function editBinName(event) {
    event.target.classList.add("d-none")

    var parentElement = event.target.parentElement

    var barcodeBtn = parentElement.querySelector('.barcode-btn')
    barcodeBtn.classList.add("d-none")
    var saveBtn = parentElement.querySelector('.save-btn')
    saveBtn.classList.remove("d-none")
    var cancelBtn = parentElement.querySelector('.cancel-btn')
    cancelBtn.classList.remove("d-none")
    var deleteBtn = parentElement.parentElement.querySelector('.delete-btn')
    deleteBtn.classList.remove("d-none")
    var chk = parentElement.parentElement.querySelector('.bin-checkbox')
    chk.classList.add("d-none")

    var binName = parentElement.parentElement.querySelector('.bin-name-input')
    binName.removeAttribute('readonly')
}

function cancelBinName(event) {
    event.target.classList.add("d-none")

    var parentElement = event.target.parentElement

    var barcodeBtn = parentElement.querySelector('.barcode-btn')
    barcodeBtn.classList.remove("d-none")
    var editBtn = parentElement.querySelector('.edit-btn')
    editBtn.classList.remove("d-none")
    var saveBtn = parentElement.querySelector('.save-btn')
    saveBtn.classList.add("d-none")
    var deleteBtn = parentElement.parentElement.querySelector('.delete-btn')
    deleteBtn.classList.add("d-none")
    var chk = parentElement.parentElement.querySelector('.bin-checkbox')
    chk.classList.remove("d-none")

    var divElement = parentElement.parentElement
    var binName = divElement.querySelector('.bin-name-input')
    binName.setAttribute('readonly', true)
    binName.value = divElement.dataset.binName
}

function saveBinName(event) {
    var parentElement = event.target.parentElement
    var divElement = parentElement.parentElement
    var binName = divElement.querySelector('.bin-name-input')

    var newBinName = binName.value.trim()
    if (!newBinName) {
        Swal.fire({
            icon: 'error',
            title: 'Bin Name Error',
            text: `Bin Name cannot be empty`,
            allowOutsideClick: false,
            allowEscapeKey: false,
            showConfirmButton: true,
            timer: 5000
        });
        return
    }
    else if (newBinName == divElement.dataset.binName) {
        Swal.fire({
            icon: 'info',
            title: 'Bin Name Same',
            text: `Bin Name is same as previously`,
            allowOutsideClick: false,
            allowEscapeKey: false,
            showConfirmButton: true,
            timer: 5000
        });
        return
    }
    else if (newBinName.length > 10) {
        Swal.fire({
            icon: 'error',
            title: 'Bin Name Error',
            text: `Bin Name cannot more than 10 Char(s)`,
            allowOutsideClick: false,
            allowEscapeKey: false,
            showConfirmButton: true,
            timer: 5000
        });
        return
    }
    else if (!/^[A-Za-z][A-Za-z0-9\s-]*$/.test(newBinName)) {
        Swal.fire({
            icon: 'error',
            title: 'Bin Name Error',
            text: `Bin Name must start with [A-Z/a-z]`,
            allowOutsideClick: false,
            allowEscapeKey: false,
            showConfirmButton: true,
            timer: 5000
        });
        return
    }

    var LocationID = document.getElementById("selectLocation").value
    var token = $('input[name="__RequestVerificationToken"]').val()

    $.ajax({
        url: ChangeBinNameUrl,
        type: "POST",
        headers: {
            'RequestVerificationToken': token
        },
        contentType: "application/json",
        data: JSON.stringify({
            LocID: LocationID,
            BinID: divElement.dataset.binId,
            NewBinName: newBinName
        }),
        success: function (response) {
            if (response.success) {
                event.target.classList.add("d-none")
                var barcodeBtn = parentElement.querySelector('.barcode-btn')
                barcodeBtn.classList.remove("d-none")
                var editBtn = parentElement.querySelector('.edit-btn')
                editBtn.classList.remove("d-none")

                var cancelBtn = parentElement.querySelector('.cancel-btn')
                cancelBtn.classList.add("d-none")

                var deleteBtn = parentElement.parentElement.querySelector('.delete-btn')
                deleteBtn.classList.add("d-none")

                var chk = parentElement.parentElement.querySelector('.bin-checkbox')
                chk.classList.remove("d-none")

                binName.setAttribute('readonly', true)
                divElement.dataset.binName = response.binName
                binName.value = divElement.dataset.binName
            }
            else {
                Swal.fire({
                    icon: 'info',
                    title: 'Failed Rename Bin',
                    text: `${response.message}`,
                    allowOutsideClick: false,
                    allowEscapeKey: false,
                    showConfirmButton: true
                })
            }
        },
        error: function (xhr, status, error) {
            Swal.fire({
                icon: 'error',
                title: 'Error Creating Bin',
                text: `An error occurred while creating the bin(s): ${xhr.responseText}`,
                allowOutsideClick: false,
                allowEscapeKey: false,
                showConfirmButton: true
            });
        }
    })
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

// #region Delete Functions
function deleteBinName(event) {
    const parentElement = event.target.parentElement;
    const divElement = parentElement.parentElement;
    const binName = divElement.dataset.binName;

    Swal.fire({
        icon: 'warning',
        title: strings.confirmDelete || 'Confirm Delete',
        html: `${strings.confirmDeleteMessage || 'Are you sure you want to delete bin'} <strong>${binName}</strong>?`,
        showCancelButton: true,
        confirmButtonColor: '#d33',
        cancelButtonColor: '#3085d6',
        confirmButtonText: strings.yes || 'Yes, delete it!',
        cancelButtonText: strings.no || 'No, cancel',
        allowOutsideClick: false,
        allowEscapeKey: false
    }).then((result) => {
        if (result.isConfirmed) {
            performDeleteBin(binName);
        }
    });
}

function deleteMultipleBins(event) {
    const selectedBin = document.querySelector('#MultipleSelectionInputControl');
    
    if (!selectedBin || !selectedBin.value || selectedBin.value.trim() === '') {
        Swal.fire({
            icon: 'warning',
            title: strings.noBinsSelected || 'No Bins Selected',
            text: strings.pleaseSelectBins || 'Please select at least one bin to delete',
            allowEscapeKey: false,
            allowOutsideClick: false,
            timer: 5000,
            showConfirmButton: true
        });
        return;
    }

    const binNames = selectedBin.value

    Swal.fire({
        icon: 'warning',
        title: strings.confirmDelete || 'Confirm Delete',
        html: `${strings.confirmDeleteMessage || 'Are you sure you want to delete these bins'}?<br><br><strong>${binNames}</strong>`,
        showCancelButton: true,
        confirmButtonColor: '#d33',
        cancelButtonColor: '#3085d6',
        confirmButtonText: strings.yes || 'Yes, delete them!',
        cancelButtonText: strings.no || 'No, cancel',
        allowOutsideClick: false,
        allowEscapeKey: false
    }).then((result) => {
        if (result.isConfirmed) {
            performDeleteBin(binNames);
        }
    });
}

function performDeleteBin(binNames) {
    const locationID = document.getElementById("selectLocation").value;
    const searchQuery = $("#searchComponent").val() || "";

    Swal.fire({
        title: strings.processing || 'Processing...',
        text: strings.pleaseWait || 'Please wait while we remove bins.',
        allowOutsideClick: false,
        allowEscapeKey: false,
        didOpen: () => {
            Swal.showLoading();
        }
    });

    const token = $('input[name="__RequestVerificationToken"]').val();

    $.ajax({
        url: DeleteBinUrl,
        type: "POST",
        headers: {
            'RequestVerificationToken': token
        },
        contentType: "application/json",
        data: JSON.stringify({
            LocID: locationID,
            BinNames: binNames,
            SearchQuery: searchQuery
        }),
        success: function (response) {
            if (response.success) {
                Swal.fire({
                    icon: 'success',
                    title: strings.binDeleted || 'Bin Deleted',
                    html: response.message,
                    allowOutsideClick: false,
                    allowEscapeKey: false,
                    showConfirmButton: true,
                    timer: 5000
                }).then(() => {
                    const collectionContainer = $("#collectionContainer");
                    collectionContainer.html(response.html);

                    attachCardEventListeners();

                    const itemCount = collectionContainer.find('.card').length;
                    updateSearchResultInfo(itemCount, searchQuery);
                });
            } else {
                Swal.fire({
                    icon: 'error',
                    title: strings.errorDeletingBin || 'Error Deleting Bin',
                    text: response.message,
                    allowOutsideClick: false,
                    allowEscapeKey: false,
                    showConfirmButton: true,
                    timer: 5000
                });
            }
        },
        error: function (xhr, status, error) {
            Swal.close();
            Swal.fire({
                icon: 'error',
                title: strings.errorDeletingBin || 'Error Deleting Bin',
                text: `${strings.errorOccurredDeletingBin || 'An error occurred while deleting the bin(s):'} ${xhr.responseText}`,
                allowOutsideClick: false,
                allowEscapeKey: false,
                showConfirmButton: true,
                timer: 5000
            });
        }
    });
}
// #endregion

// #region Search Functions
function searchFunction(event) {
    if (event.key === 'Enter' || event.keyCode === 13 || event.which === 13) {
        event.preventDefault();
        const searchQuery = $(event.target).val() || "";
        performAjaxSearch(searchQuery);
    }
}

function performAjaxSearch(searchQuery) {
    const collectionContainer = $("#collectionContainer");

    // Get current page context - use selectedLocation for view mode
    const locationID = $("#selectedLocation").data("locid") || 
                       $("#selectLocation").val() || "";

    if (!locationID) {
        Swal.fire({
            icon: "warning",
            title: strings.location || "Location",
            text: strings.pleaseChooseLocation || "Please choose Location",
            allowEscapeKey: false,
            allowOutsideClick: false,
            timer: 5000,
            showConfirmButton: true
        });
        return;
    }

    // Show loading indicator
    showLoadingIndicator();

    // jQuery AJAX request
    $.ajax({
        url: SearchBinMasterUrl,
        type: 'GET',
        data: {
            LocID: locationID,
            searchQuery: searchQuery,
        },
        success: function (htmlResponse) {
            // Simply replace the container HTML with server-rendered content
            collectionContainer.html(htmlResponse);
            
            requestAnimationFrame(() => {
                // Re-attach event listeners to new cards
                attachCardEventListeners();

                // Show search result info
                const itemCount = collectionContainer.find('.card').length;
                updateSearchResultInfo(itemCount, searchQuery);

                // Show/hide clear button
                toggleClearButton(searchQuery);
            });
        },
        error: function (xhr, status, error) {
            console.error('AJAX search error:', error);
            showErrorMessage(strings.errorOccurredSearching || "An error occurred while searching. Please try again.");
        }
    });
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
                        <p class="mt-3 text-muted fw-semibold">🔍 ${strings.searching || 'Searching'}...</p>
                    </div>
                </div>
            </div>
        `);
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
// #endregion

//#region Method
function attachCardEventListeners() {
    // Re-attach barcode button listeners
    const barcodeBtn = document.querySelectorAll('.barcode-btn');
    if (barcodeBtn) {
        barcodeBtn.forEach(btn => {
            btn.removeEventListener('click', generateQRCode);
            btn.addEventListener('click', generateQRCode);
        });
    }

    // Re-attach edit button listeners
    const editBtn = document.querySelectorAll('.edit-btn');
    if (editBtn) {
        editBtn.forEach(btn => {
            btn.removeEventListener('click', editBinName);
            btn.addEventListener('click', editBinName);
        });
    }

    // Re-attach save button listeners
    const saveBtn = document.querySelectorAll('.save-btn');
    if (saveBtn) {
        saveBtn.forEach(btn => {
            btn.removeEventListener('click', saveBinName);
            btn.addEventListener('click', saveBinName);
        });
    }

    // Re-attach cancel button listeners
    const cancelBtn = document.querySelectorAll('.cancel-btn');
    if (cancelBtn) {
        cancelBtn.forEach(btn => {
            btn.removeEventListener('click', cancelBinName);
            btn.addEventListener('click', cancelBinName);
        });
    }

    // Re-attach delete button listeners
    const deleteBtn = document.querySelectorAll('.delete-btn');
    if (deleteBtn) {
        deleteBtn.forEach(btn => {
            btn.removeEventListener('click', deleteBinName);
            btn.addEventListener('click', deleteBinName);
        });
    }

    // Re-attach checkbox listeners
    const chkGenerateMultiple = document.querySelectorAll(".bin-checkbox");
    if (chkGenerateMultiple) {
        chkGenerateMultiple.forEach(chk => {
            chk.removeEventListener("change", GeneratBinNameBarcode);
            chk.addEventListener("change", GeneratBinNameBarcode);
        });
    }
}
function updateSearchResultInfo(count, searchQuery) {
    const resultInfo = $("#searchResultInfo");
    const resultCount = $("#searchResultCount");

    if (resultInfo.length > 0 && resultCount.length > 0) {
        if (searchQuery && searchQuery.trim() !== "") {
            resultCount.text(`${strings.found || 'Found'} ${count} ${strings.binMatching || 'bin(s) matching'} "${searchQuery}"`);
        } else {
            resultCount.text(`${strings.showing || 'Showing'} ${count} ${strings.bins || 'bin(s)'}`);
        }
    }
}
//#endregion