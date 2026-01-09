document.addEventListener("DOMContentLoaded", function () {
    const btnResetQty = document.querySelectorAll('.resetqty')
    btnResetQty.forEach(btn => {
        btn.addEventListener("click", ResetQty)
    })

    const btnUnlockBins = document.querySelectorAll('.unlockbin')
    btnUnlockBins.forEach(btn => {
        btn.addEventListener("click", UnlockBin)
    })

    $("#searchComponent").on("keydown", searchFunction);
    $("#searchButton").on("click", function () {
        const searchQuery = $("#searchComponent").val() || "";
        performAjaxSearch(searchQuery);
    });

    // Add click handler for clear button
    $("#clearSearchButton").on("click", clearSearch);
})

const strings = window.LocalizedStrings || {};
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
function performAjaxSearch(searchQuery) {
    const collectionContainer = $("#collectionContainer");

    const locationID = $("#selectLocation").val() || $("select[name='LocID']").val() ||
        $("#selectedLocation").data("locid") || "";

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
        url: SearchItemsBinStockUrl,
        type: 'GET',
        data: {
            LocID: locationID,
            searchQuery: searchQuery,
            onViewMode: ViewMode
        },
        success: function (htmlResponse) {
            // Simply replace the container HTML with server-rendered content
            collectionContainer.html(htmlResponse);

            // Restore client state to the new cards
            restoreItemListToCards();

            // Re-attach event listeners to new cards
            attachCardEventListeners();

            // Show search result info
            const itemCount = collectionContainer.find('.card-clickable').length;
            updateSearchResultInfo(itemCount, searchQuery);

            // Show/hide clear button
            toggleClearButton(searchQuery);
        },
        error: function (xhr, status, error) {
            console.error('AJAX search error:', error);
            showErrorMessage("An error occurred while searching. Please try again.");
        }
    });
}
function restoreItemListToCards() {
    if (!originalData || originalData.length === 0) return;
    
    originalData.forEach(savedData => {
        const card = document.getElementById(savedData.MultiBatchBalanceBinID);
        
        if (card && savedData.EditBinQty != null) {
            const qtyInput = card.querySelector('.qty-input');
            
            if (qtyInput) {
                // Restore the edited quantity value
                qtyInput.value = savedData.EditBinQty;
                
                // Restore the unlock state if applicable
                if (savedData.isUnlock) {
                    qtyInput.classList.add("isUnlock");
                    qtyInput.disabled = false;
                    
                    // Update the unlock button
                    const unlockBtn = card.querySelector('.unlockbin');
                    if (unlockBtn) {
                        unlockBtn.textContent = strings.lock || 'Lock';
                        unlockBtn.classList.remove('btn-success');
                        unlockBtn.classList.add('btn-danger');
                    }
                    
                    // Update card background
                    card.classList.remove("bg-danger", "bg-white");
                    card.classList.add("bg-success", "text-white");
                }
                // Restore the modified state (bg-info) for editable items
                else if (!savedData.isUnlock && savedData.BinQty != savedData.EditBinQty) {
                    card.classList.remove('bg-white');
                    card.classList.add('bg-info');
                }
            }
        }
    });
}
function attachCardEventListeners() {
    // Re-attach reset qty button listeners
    const btnResetQty = document.querySelectorAll('.resetqty');
    btnResetQty.forEach(btn => {
        btn.removeEventListener("click", ResetQty); // Remove old listener
        btn.addEventListener("click", ResetQty);
    });

    // Re-attach unlock bin button listeners
    const btnUnlockBins = document.querySelectorAll('.unlockbin');
    btnUnlockBins.forEach(btn => {
        btn.removeEventListener("click", UnlockBin); // Remove old listener
        btn.addEventListener("click", UnlockBin);
    });
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
function updateSearchResultInfo(count, searchQuery) {
    const resultInfo = $("#searchResultInfo");
    const resultCount = $("#searchResultCount");

    if (resultInfo.length > 0 && resultCount.length > 0) {
        if (searchQuery && searchQuery.trim() !== "") {
            resultCount.text(`Found ${count} item(s) matching "${searchQuery}"`);
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
function clearSearch() {
    const searchInput = $("#searchComponent");
    if (searchInput.length > 0) {
        searchInput.val("");
        performAjaxSearch("");
    }
}
function ResetQty(event) {
    const MBBBinid = event.target.dataset.mbbbId;
    originalData.some(data => {
        if (data.MultiBatchBalanceBinID == MBBBinid) {
            data.EditBinQty = null;
            const cardContainer = document.getElementById(MBBBinid)
            cardContainer.classList.remove('bg-info')
            cardContainer.classList.add("bg-white")
            const input = cardContainer.querySelector('.qty-input')
            input.value = data.BinQty
            return true;
        }
    })
}
function UnlockBin(event) {
    const lockUnlockContainer = event.target.closest('.lock-unlock-container')
    const qtyInputEl = lockUnlockContainer.querySelector('.qty-input')
    const mbbbId = qtyInputEl.dataset.mbbbId
    const cardContainer = lockUnlockContainer.closest(`[id="${mbbbId}"]`)
    if (qtyInputEl.classList.contains('isUnlock')) {
        qtyInputEl.disabled = true;
        qtyInputEl.classList.remove("isUnlock")
        qtyInputEl.value = qtyInputEl.dataset.binqty
        event.target.textContent = strings.unlock
        event.target.classList.remove('btn-danger')
        event.target.classList.add('btn-success')
        cardContainer.classList.remove("bg-sucess")
        cardContainer.classList.add("bg-danger")
    }
    else {
        qtyInputEl.classList.add("isUnlock")
        qtyInputEl.disabled = false;
        event.target.textContent = strings.lock
        event.target.classList.remove('btn-success')
        event.target.classList.add('btn-danger')
        cardContainer.classList.remove("bg-danger")
        cardContainer.classList.add("bg-success")
    }

    originalData.some(a => {
        if (a.MultiBatchBalanceBinID == mbbbId) {
            a.isUnlock = qtyInputEl.classList.contains('isUnlock') || null
            a.EditBinQty = (a.isUnlock == null) ? null : a.BinQty
        }
    })
}
function ChangedQty(element) {
    const MBBBinID = element.dataset.mbbbId
    const maxQty = parseFloat(element.max)
    let userInput = parseFloat(element.value)

    if (isNaN(userInput) || userInput < 0 || element.value.trim() == "") {
        element.value = 0;
    }
    else if (userInput > maxQty) {
        element.value = maxQty
    }

    element.value = Math.round(element.value * 100)/100

    let modifiedData = {
        MultiBatchBalanceBinID: MBBBinID,
        EditBinQty: element.value
    }

    originalData.some(a => {
        if (a.MultiBatchBalanceBinID == modifiedData.MultiBatchBalanceBinID) {
            a.EditBinQty = modifiedData.EditBinQty
            const cardContainer = document.getElementById(MBBBinID)
            if (a.isUnlock == null || a.isUnlock == false) {
                if (a.BinQty == a.EditBinQty) {
                    if (cardContainer.dataset.isopen == "True") {
                        cardContainer.classList.remove('bg-info')
                        cardContainer.classList.add('bg-white')
                    }
                }
                else {
                    cardContainer.classList.remove('bg-white')
                    cardContainer.classList.add('bg-info')
                }
            }
            return true
        }
    })
}
function onEditConfirmed(event) {
    let selected = document.getElementById("selectLocation");
    if (!selected || !selected.value || selected.value === "" || selected.value === "-- Select Location --" || selected.value === "-- Pilih Lokasi --") {
        event.preventDefault()
        Swal.fire({
            icon: "warning",
            title: strings.location || "Location",
            text: strings.pleaseChooseLocation || "Please choose Location",
            allowEscapeKey: false,
            allowOutsideClick: false,
            timer: 3000,
            showConfirmButton: true
        });
        return;
    }
    //dataToSend = document.getElementById("selectLocation").value
    const searchComponent = document.getElementById("searchComponent");
    const searchQuery = searchComponent ? searchComponent.value : "";
    const locationID = document.getElementById("selectLocation").value

    dataToSend = {
        LocationID: locationID,
        SearchQuery: searchQuery
    };
}
function onCancelConfirmed() {
    //dataToSend = document.getElementById("selectedLocation").dataset.locid
    const searchComponent = document.getElementById("searchComponent");
    const searchQuery = searchComponent ? searchComponent.value : "";
    let locationID = document.getElementById("selectedLocation")?.dataset.locid || null;

    dataToSend = {
        LocationID: locationID,
        SearchQuery: searchQuery
    };
}
function onSaveConfirmed() {
    console.log(dataToSend)
}
function assignDataToSend() {
    const locIDContainer = document.getElementById('selectedLocation')
    const LocID = locIDContainer.dataset.locid
    const searchComponent = document.getElementById("searchComponent");
    const searchQuery = searchComponent ? searchComponent.value : "";

    dataToSend = { Datas: [] }
    originalData.forEach(data => {
        if (data.EditBinQty != null && ((data.EditBinQty != data.BinQty && data.isUnlock == null) || data.isUnlock)) {
            dataToSend.Datas.push(data)
        }
    })
    if (dataToSend.Datas.length > 0 && LocID) {
        dataToSend.LocID = LocID
        dataToSend.SearchQuery = searchQuery
    }
    else {
        dataToSend = null
    }
    return true;
}


//#region Search (Client side) (Not used)
//function searchFunction(event) {
//    console.log(originalData)
//    let collectionContainer = document.getElementById('collectionContainer')
//    collectionContainer.innerHTML = "";
//    let searchResults = []
//    let searchQuery = event.target.value.trim().toLowerCase();;
//    if (searchQuery && searchQuery == "") {
//        searchResults = originalData
//    }
//    else {
//        originalData.forEach(data => {
//            if (searchQuery.length >= 30) {
//                searchResults = originalData.filter(item =>
//                    item.Barcode && item.Barcode.toLowerCase().includes(searchQuery)
//                )
//            }
//            else {
//                searchResults = originalData.filter(item =>
//                    item.ItemID.toLowerCase().includes(searchQuery)
//                    || item.NIE_BPOM.toLowerCase().includes(searchQuery)
//                    || item.BatchID.toLowerCase().includes(searchQuery)
//                    || item.ItemName.toLowerCase().includes(searchQuery)
//                    || item.BinName.toLowerCase().includes(searchQuery)
//                    || (item.Barcode && item.Barcode.toLowerCase().includes(searchQuery))
//                )
//            }
//        })
//    }

//    function highlightText(text, query) {
//        if (!query) return text;
//        const regex = new RegExp(`(${query})`, "gi");
//        return text.replace(regex, `<span style="background-color: yellow;">$1</span>`);
//    }

//    if (searchResults.length > 0) {
//        searchResults.forEach(data => {
//            let divCard = document.createElement('div')
//            let divCardClass = "border p-2 mb-3 rounded shadow-sm"
//            divCard.className = divCardClass
//            divCard.dataset.isopen = data.isOpen

//            if (!data.isOpen && data.BinQty > 0 && !data.isUnlock) {
//                divCard.classList.add("bg-danger", "text-white")
//            }
//            else if (!data.isOpen && data.BinQty > 0 && data.isUnlock) {
//                divCard.classList.add("bg-success", "text-white")
//            }
//            else if (data.EditBinQty == null || data.BinQty == data.EditBinQty) {
//                divCard.classList.add("bg-white", "text-black")
//            }
//            else {
//                divCard.classList.add("bg-info", "text-black")
//            }
//            divCard.id = data.MultiBatchBalanceBinID

//            function createDiv(label, value) {
//                const div = document.createElement('div');
//                const safeValue = value ? value.toString() : "";
//                div.innerHTML = `<strong>${label}:</strong> ${highlightText(safeValue, searchQuery)}`;
//                return div;
//            }

//            divCard.appendChild(createDiv(strings.item || "Item", `${data.ItemName} - (${data.ItemID})`));
//            divCard.appendChild(createDiv(strings.binName || "Bin Name", data.BinName));
//            divCard.appendChild(createDiv(strings.nieBpom || "NIE_BPOM", data.NIE_BPOM));
//            divCard.appendChild(createDiv(strings.batch || "Batch", data.BatchID));
//            divCard.appendChild(createDiv(strings.expiredDate || "Expired Date", data.ExpiredDate));
//            divCard.appendChild(createDiv(strings.barcode || "Barcode", data.Barcode));
//            if (!ViewMode) {
//                const editdiv = document.createElement('div')
//                editdiv.className = "d-flex align-items-center mb-2 lock-unlock-container"
//                const editstrong = document.createElement('div')
//                editstrong.className = "me-3"
//                editstrong.textContent = (strings.binQty || "Bin Qty") + ": "
//                const editinput = document.createElement('input')
//                editinput.type = "number"
//                editinput.className = "form-control form-control-sm text-center w-auto qty-input"
//                editinput.max = `${data.MaxBinQty}`
//                editinput.min = "0"
//                editinput.dataset.mbbbId = `${data.MultiBatchBalanceBinID}`
//                editinput.dataset.binqty = data.BinQty
//                editinput.value = data.EditBinQty ?? data.BinQty
//                editinput.setAttribute("onchange", "ChangedQty(this)")

//                const editbutton = document.createElement('button')
//                editbutton.type = 'button'
//                editbutton.className = 'btn btn-sm  rounded-pill shadow-sm ms-3'
//                editbutton.dataset.mbbbId = data.MultiBatchBalanceBinID

//                if (!data.isOpen && data.BinQty > 0) {
//                    if (data.isUnlock) {
//                        editinput.classList.add('isUnlock')
//                        editbutton.classList.add('unlockbin', 'btn-danger')
//                        editbutton.textContent = (strings.lock || 'Lock')
//                    }
//                    else {
//                        editbutton.classList.add('unlockbin', 'btn-success')
//                        editbutton.textContent = (strings.unlock || 'Unlock')
//                    }
//                    //editbutton.className = 'btn btn-sm rounded-pill shadow-sm ms-3 unlockbin btn-success'
//                    editbutton.addEventListener('click', UnlockBin)
//                }
//                else {
//                    editbutton.classList.add('btn-warning', 'resetqty')
//                    //editbutton.className = 'btn btn-sm btn-warning rounded-pill shadow-sm ms-3 resetqty'
//                    editbutton.addEventListener('click', ResetQty)

//                    const editi = document.createElement('i')
//                    editi.className = 'bi bi-arrow-counterclockwise'
//                    editbutton.appendChild(editi)
//                    editbutton.append(' ' + (strings.reset || 'Reset'))
//                }

//                editdiv.appendChild(editstrong)
//                editdiv.appendChild(editinput)
//                editdiv.appendChild(editbutton)
//                if (!data.isOpen && data.BinQty > 0) {
//                    if (data.isUnlock) {
//                        editinput.disabled = false;
//                    }
//                    else {
//                        editinput.disabled = true;
//                    }
//                    const editspan = document.createElement('span')
//                    editspan.className = 'ms-2 mt-2 mt-sm-0 badge text-dark bg-info border border-warning rounded-pill px-3 py-2 shadow-sm'
//                    editspan.textContent = (strings.unlockWarning || 'Unlocking this qty will affect the real balance')
//                    editdiv.appendChild(editspan)
//                }
//                divCard.appendChild(editdiv)
//            }
//            else {
//                divCard.appendChild(createDiv(strings.binQty || "Bin Qty", data.EditBinQty ?? data.BinQty));
//            }

//            collectionContainer.appendChild(divCard)
//        })
//    }
//    else {
//        collectionContainer.innerHTML = `<span class="text-muted d-flex justify-content-center pt-3 alert alert-info">${strings.noItem || 'No Item'}</span>`
//    }
//}
//#endregion

//#region Comments Function
//function exportQRToPDF() {
//    const element = document.getElementById("barcodeContainer");
//    if (!element || element.innerHTML.trim() === "" || element.classList.contains("empty")) {
//        Swal.fire({
//            icon: 'error',
//            title: 'No QR Codes',
//            text: 'Please generate QR codes first'
//        });
//        return;
//    }

//    // Create a hidden clone to force consistent layout (grid) and a fixed A4 width
//    const clone = element.cloneNode(true);
//    // Apply fixed A4 width in pixels (approx at 96dpi: 210mm ~= 794px) so layout is stable across devices
//    clone.style.width = '794px';
//    clone.style.boxSizing = 'border-box';
//    clone.style.padding = '10px';
//    clone.style.background = '#ffffff';
//    // Force a grid layout (3 columns) to mimic desktop arrangement regardless of viewport
//    clone.style.display = 'grid';
//    clone.style.gridTemplateColumns = 'repeat(3, 1fr)';
//    clone.style.gap = '20px';
//    clone.style.alignItems = 'start';

//    // Adjust each QR wrapper to have fixed size and centered content
//    const wrappers = clone.querySelectorAll('div.d-flex');
//    wrappers.forEach(w => {
//        w.style.display = 'flex';
//        w.style.flexDirection = 'column';
//        w.style.alignItems = 'center';
//        w.style.justifyContent = 'center';
//        w.style.width = '240px';
//        w.style.minHeight = '240px';
//        w.style.margin = '0';
//    });

//    // Hide the clone offscreen while rendering
//    clone.style.position = 'absolute';
//    clone.style.left = '-9999px';
//    document.body.appendChild(clone);

//    // Use devicePixelRatio to improve quality on high-DPI devices
//    const dpr = window.devicePixelRatio || 1;
//    const scale = Math.max(2, Math.round(dpr * 2));

//    requestAnimationFrame(() => {
//        html2canvas(clone, { scale: scale, useCORS: true }).then(canvas => {
//            const imgData = canvas.toDataURL('image/jpeg', 1.0);

//            const { jsPDF } = window.jspdf;
//            const pdf = new jsPDF({
//                orientation: 'portrait',
//                unit: 'mm',
//                format: 'a4'
//            });

//            const pageWidth = pdf.internal.pageSize.getWidth();
//            const imgWidth = pageWidth - 20;
//            const imgHeight = canvas.height * imgWidth / canvas.width;

//            const today = new Date();
//            const day = String(today.getDate()).padStart(2, '0');
//            const monthNames = ["January", "February", "March", "April", "May", "June",
//                "July", "August", "September", "October", "November", "December"];
//            const month = monthNames[today.getMonth()];
//            const year = today.getFullYear();
//            const filename = `QR_Codes_${month}_${day}_${year}.pdf`;

//            pdf.addImage(imgData, 'JPEG', 10, 10, imgWidth, imgHeight);
//            pdf.save(filename);

//            // Clean up clone
//            document.body.removeChild(clone);
//        }).catch(err => {
//            document.body.removeChild(clone);
//            Swal.fire({
//                icon: 'error',
//                title: 'Error Exporting PDF',
//                text: err && err.message ? err.message : 'An error occurred while exporting the PDF.'
//            });
//        });
//    });
//}
//function generateQR() {
//    const text = document.getElementById("barcodeInput").value.trim();
//    const qrContainer = document.getElementById("barcodeContainer");
//    qrContainer.innerHTML = "";
//    qrContainer.classList.remove("empty")

//    if (!text) {
//        qrContainer.innerHTML = "<div class='text-danger'>Text is empty</div>";
//        qrContainer.classList.add("empty")
//        return;
//    }
//    let rejectedBins = []

//    let binNameColl = text.split(";").map(a => a.trim()).filter(a => a !== "")
//    binNameColl.forEach(bin => {
//        if (bin.length > 10) {
//            rejectedBins.push(bin);
//            return; // continue to next iteration
//        }

//        const qrWrapper = document.createElement("div");
//        qrWrapper.classList.add("d-flex", "flex-column", "align-items-center", "m-3");

//        const qrBox = document.createElement("div");
//        new QRCode(qrBox, {
//            text: bin,
//            width: 160,
//            height: 160
//        });

//        const label = document.createElement("div");
//        label.textContent = bin;
//        label.classList.add("mt-2", "fw-bold");

//        qrWrapper.appendChild(qrBox);
//        qrWrapper.appendChild(label);
//        qrContainer.appendChild(qrWrapper);
//    });

//    // Show SweetAlert if any bin is rejected
//    if (rejectedBins.length > 0) {
//        Swal.fire({
//            icon: 'warning',
//            title: 'Rejected Bin',
//            html: `<strong>Reason:</strong> Exceeds 10 characters<br><br><ul style="text-align:left">${rejectedBins.map(bin => `<li>${bin}</li>`).join('')}</ul>`,
//        });
//    }
//}
//#endregion