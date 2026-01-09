//#region Global Variable
// Camera Variable
let isCameraOpen = false; let isCameraBusy = false; let isProcessing = false; let scanner = null;
// Modal Variable
let modalItemList = [] //Data Store when modal is open
//#endregion

document.querySelectorAll('.camera-draggable').forEach(makeDraggable);
document.addEventListener("DOMContentLoaded", function () {
    //const selectElement = document.getElementById('LocationSelect')
    //if (selectElement) {
    //    selectElement.addEventListener('change', ChangedLocation)
    //}

    const LocationSelection = document.getElementById("LocationSelect");

    if (LocationSelection) {
        $(LocationSelection).select2({
            placeholder: $(LocationSelection).data('placeholder') || '-- Select Location --',
            allowClear: false,
            width: '100%',
            theme: 'bootstrap-5',
            language: {
                noResults: function () {
                    return 'No locations found';
                },
                searching: function () {
                    return 'Searching...';
                }
            }
        });

        $(LocationSelection).on('change', function (e) {
            ChangedLocation(e);
        });

        // Auto-focus on search box when dropdown opens (Desktop & Mobile)
        $('#LocationSelect').on('select2:open', function (e) {
            // Small delay to ensure dropdown is rendered
            setTimeout(function () {
                // Find the search input in the dropdown
                const searchField = document.querySelector('.select2-search__field');
                if (searchField) {
                    searchField.focus();
                }
            }, 50);
        });
    }

    const transactionNoField = document.getElementById('transactionNoField');
    if (transactionNoField) {
        transactionNoField.addEventListener('keypress', function (e) {
            if (e.key === 'Enter') {
                searchTransaction(e);
            }
        });
    }

    const searchTransactionBtn = document.getElementById('searchTransactionBtn');
    if (searchTransactionBtn) {
        searchTransactionBtn.addEventListener('click', searchTransaction);
    }
})
function makeDraggable(el) {
    let offsetX = 0, offsetY = 0, isDragging = false; dragDelayTimer = null

    el.addEventListener('mousedown', startDrag);
    el.addEventListener('touchstart', startDrag, { passive: false });

    function startDrag(e) {
        dragDelayTimer = setTimeout(() => {
            isDragging = true;
            el.style.cursor = "grabbing";
            const rect = el.getBoundingClientRect();

            if (e.type === 'mousedown') {
                offsetX = e.clientX - rect.left;
                offsetY = e.clientY - rect.top;
                document.addEventListener('mousemove', drag);
                document.addEventListener('mouseup', stopDrag);
            } else {
                offsetX = e.touches[0].clientX - rect.left;
                offsetY = e.touches[0].clientY - rect.top;
                document.addEventListener('touchmove', drag, { passive: false });
                document.addEventListener('touchend', stopDrag);
            }
        }, 10)
    }

    function drag(e) {
        if (!isDragging) return;

        let x = e.type === 'mousemove' ? e.clientX : e.touches[0].clientX;
        let y = e.type === 'mousemove' ? e.clientY : e.touches[0].clientY;

        el.style.left = `${x - offsetX}px`;
        el.style.top = `${y - offsetY}px`;
        el.style.bottom = "auto";
        el.style.transform = "none";
        if (e.cancelable) e.preventDefault();
    }

    function stopDrag(e) {
        clearTimeout(dragDelayTimer);
        isDragging = false;
        el.style.cursor = "grab";
        if(isDragging){
            if (e.cancelable) e.preventDefault();
            e.stopPropagation();
            document.removeEventListener('mousemove', drag);
            document.removeEventListener('mouseup', stopDrag);
            document.removeEventListener('touchmove', drag);
            document.removeEventListener('touchend', stopDrag);
        }
    }
}
function OpenCloseCamera() {
    if (isCameraBusy) return; // prevent rapid clicks
    isCameraBusy = true;
    const qrContainer = $("#qr-reader-container");
    const isHidden = qrContainer.css("display") === "none";
    if (isHidden) {
        qrContainer.fadeIn(); 
    } else {
        qrContainer.fadeOut();
    }
    const qrElement = document.getElementById("qr-reader"); //ResizeObserver only accept DOM
    let btnCamera = document.getElementById("camera-float-button")

    if (isCameraOpen) {
        scanner.stop().then(() => {
            scanner.clear();
            scanner = null;
            isCameraOpen = false;
             //btnStartScan.innerHTML = "📷 Open Camera & Scan";
            btnCamera.innerHTML = "📷";
            qrContainer.prop("hidden", true);
            isCameraBusy = false;
        }).catch(err => {
            console.error("Error stopping scanner:", err);
            isCameraBusy = false;
        });
        return;
    }
    isCameraOpen = true;
    //btnStartScan.innerHTML = "⏳ Starting Camera...";
    btnCamera.innerHTML = "⏳";
    qrContainer.prop("hidden", false);

    const observer = new ResizeObserver(entries => {
        for (let entry of entries) {
            const { width, height } = entry.contentRect;
            if (width > 0 && height > 0) {
                observer.disconnect(); // stop after size available

                scanner = new Html5Qrcode("qr-reader");
                scanner.start(
                    { facingMode: "environment" },
                    {
                        fps: 10,
                        qrbox: function (viewfinderWidth, viewfinderHeight) {
                            const minSize = Math.min(viewfinderWidth, viewfinderHeight);
                            return {
                                width: minSize * 0.8,
                                height: minSize * 0.8
                            };
                        },
                        //Bounding Box (only support for Browser has BarcodeDetector API ex: Chrome 94+, Edge, Android WebView modern)
                        experimentalFeatures: {
                            useBarCodeDetectorIfSupported: false
                        }
                    },
                    (decodedText) => {
                        if (isProcessing) return
                        isProcessing = true;
                        Swal.fire({
                            icon: 'success',
                            title: '✅ Barcode berhasil di Scan!',
                            text: 'Processing barcode...',
                            allowOutsideClick: false,
                            allowEscapeKey: false,
                            showConfirmButton: false,
                            didOpen: () => {
                                Swal.showLoading();
                            }
                        });
                        let ScannedType = decodedText.length;
                        if (ScannedType == 12) {
                            DecodeTransactionNo(decodedText)
                        }
                        else {
                            alert(decodedText);
                        }
                    },
                    (errorMessage) => {
                        //console.warn("Scan error", errorMessage);
                    }
                ).then(() => {
                    //btnStartScan.innerHTML = "❌ Close Camera";
                    btnCamera.innerHTML = "❌";
                    isCameraBusy = false;
                    isProcessing = false;
                }).catch(err => {
                    console.error("Start scanner error:", err);
                    Swal.fire({
                        icon: 'error',
                        title: 'Camera Error',
                        text: err.message || "Failed to open camera"
                    });
                    isCameraOpen = false;
                    isCameraBusy = false;
                    isProcessing = false;
                    scanner = null;
                    //btnStartScan.innerHTML = "📷 Open Camera & Scan";
                    btnStartScan.innerHTML = "📷";
                    qrContainer.prop("hidden", true);
                });
            }
        }
    });
    observer.observe(qrElement)
}
function ChangedLocation(event) {
    const prescriptionDetailContainer = document.getElementById('prescriptionDetail')
    prescriptionDetailContainer.innerHTML = ''
    const divPrescriptionDetail = document.createElement('div')
    divPrescriptionDetail.classList = 'text-muted text-center'
    divPrescriptionDetail.innerHTML = 'Select a Prescription to view details'
    prescriptionDetailContainer.appendChild(divPrescriptionDetail)

    const patientDetailContainer = document.getElementById('patientDetail')
    patientDetailContainer.innerHTML = ''
    const divPatientDetail = document.createElement('div')
    divPatientDetail.classList = 'text-muted text-center'
    divPatientDetail.innerHTML = 'Select a Prescription to view details'
    patientDetailContainer.appendChild(divPatientDetail)

    const barcodeListContainer = document.getElementById('barcodeList')
    const activePrescription = barcodeListContainer.querySelector('.barcode-item.active')
    if (activePrescription)
        activePrescription.classList.remove('active')
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
    CheckScannedData(value)
}

//#region Container 2
// Read Barcode from PC
function ReadScanner(element, code) {
    DecodeTransactionNo(code)
}
function DecodeTransactionNo(ScannerText){
    let TransactionID = "";
    let TransactionNo1 = ScannerText.substring(2, 8)
    let TransactionNo2 = ScannerText.substring(8)
    switch (ScannerText.substring(0, 1)) {
        case "1":
            TransactionID = "RSO";
            break;
        case "2":
            TransactionID = 'RSI';
            break;
        default:
            Swal.close()
            setTimeout(() => {
                Swal.fire({
                    icon: 'error',
                    title: 'ERROR',
                    text: 'PrescriptionNo is not RSO either RSI',
                    showConfirmButton: true,
                    confirmButtonText: 'OK'
                }).then(() => {
                    isProcessing = false
                });
            }, 100)
            break;
    }
    if (TransactionID) {
        let TransactioNo = `${TransactionID}/${TransactionNo1}-${TransactionNo2}`
        CheckScannedData(TransactioNo);
    }
}
// AJAX Validate TransactionNo to DB
function CheckScannedData(transactionNo) {
    let details = []
    const barcodeListContainer = document.getElementById('barcodeList')
    const barcodeList = barcodeListContainer.querySelectorAll('.barcode-item')
    barcodeList.forEach(li => {
        details.push({
            PrescriptionNo: li.dataset.barcode.trim(),
            Patient: li.dataset.patient.trim(),
            RegistrationNo: li.dataset.regno.trim(),
            MedicalNo: li.dataset.medicalNo.trim(),
            Sex: li.dataset.sex.trim(),
            Weight: li.dataset.weight.trim(),
            Height: li.dataset.height.trim(),
            Age: li.dataset.age.trim(),
            Approved: li.dataset.approved.trim(),
            Delivered: li.dataset.delivered.trim()
        })
    })
    const payload = {
        PrescriptionNo: transactionNo,
        Details: details
    }
    var token = $('input[name="__RequestVerificationToken"]').val();
    $.ajax({
        url: CheckScannedDataUrl,
        method: 'POST',
        headers: {
            'RequestVerificationToken': token
        },
        contentType: 'application/json',
        data: JSON.stringify(payload),
        success: function (response) {
            Swal.close();
            $('#barcodeList').html(response);
            Swal.fire({
                icon: 'success',
                title: 'Barcode scanned!',
                text: `PrescriptionNo: ${transactionNo}`,
                timer: 5000,
                showConfirmButton: true
            }).then(() => {
                isProcessing = false;
            });
        },
        error: function (xhr) {
            console.error("AJAX error: " + xhr);
            Swal.close();
            setTimeout(() => {
                Swal.fire({
                    icon: 'error',
                    title: 'Oops...',
                    text: 'Failed to Check PrescriptionNo.'
                }).then(() => {
                    isProcessing = false;
                });
            }, 100);
        }
    });
}
// AJAX Get Detail of TransactionNo
function SelectedPrescriptionNo(element) {
    //var LocationElement = document.getElementById("LocationSelect");
    var LocationElement = $('#LocationSelect');

    if (!LocationElement.length || !LocationElement.val()) {
        Swal.fire({
            icon: 'info',
            title: "Location Error",
            text: `Please Choose Location`,
            timer: 5000,
            showConfirmButton: true
        });
        return;
    }

    $(".barcode-item").removeClass('active');
    $(element).addClass('active');
    const prescriptionDetailContainer = document.getElementById('prescriptionDetail')
    prescriptionDetailContainer.innerHTML = ''
    const divPrescriptionDetail = document.createElement('div')
    divPrescriptionDetail.classList = 'text-muted text-center'
    divPrescriptionDetail.innerHTML = 'Get Data from Database, Please Wait...'
    prescriptionDetailContainer.appendChild(divPrescriptionDetail)

    const patientDetailContainer = document.getElementById('patientDetail')
    patientDetailContainer.innerHTML = ''
    const divPatientDetail = document.createElement('div')
    divPatientDetail.classList = 'text-muted text-center'
    divPatientDetail.innerHTML = 'Get Data from Database, Please Wait...'
    patientDetailContainer.appendChild(divPatientDetail)

    const payload = {
        PrescriptionNo: $(element).data("barcode"),
        PatientName: $(element).data("patient"),
        RegistrationNo: $(element).data("regno"),
        MedicalNo: $(element).data("medicalNo"),
        Age: ($(element).data("age") ?? "").toString(),
        Sex: $(element).data("sex"),
        Weight: $(element).data("weight"),
        Height: $(element).data("height"),
        LocationID: LocationElement.val().trim(),
        Approval: $(element).data("approved"),
        Delivered: $(element).data("delivered")
    }

    var token = $('input[name="__RequestVerificationToken"]').val();
    $.ajax({
        url: DetailTransactionUrl,
        method: 'POST',
        headers: {
            'RequestVerificationToken': token
        },
        contentType: 'application/json',
        data: JSON.stringify(payload),
        success: function (response) {
            $('#selectedDetail').html(response);
        },
        error: function (xhr, status, error) {
            divPrescriptionDetail.innerHTML = 'Failed to Get Data from Database';
            divPatientDetail.innerHTML = 'Failed to Get Data from Database';

            // Handle error response
            console.error("Error during fetch:", error);
            Swal.fire({
                icon: 'info',
                title: "Error",
                text: `Failed to fetch prescription details.`,
                timer: 3000,
                showConfirmButton: true
            });
        }
    });
}
//#endregion

//#region Container 4
// AJAX and open modal for changing detail
function ChangeDetail(element, prescriptionNo, itemId, itemName) {
    const cardElement = document.getElementById(`card-${itemId}`);
    const coll = cardElement.querySelectorAll(".detailEDBatch");
    var modalData = []

    coll.forEach(edbatch => {
        modalData.push({
            NIE_BPOM: edbatch.dataset.bpom.trim(),
            Batch: edbatch.dataset.batch.trim(),
            ExpiredDate: edbatch.dataset.ed.trim(),
            BinID: edbatch.dataset.binId.trim(),
            BinName: edbatch.dataset.binName.trim(),
            Qty: edbatch.dataset.qty.trim(),
        })
    })
    const modalElement = document.getElementById('modal-container');
    modalElement.innerHTML = '';

    //var locationElement = document.getElementById("LocationSelect")
    var LocationElement = $('#LocationSelect');
    var token = $('input[name="__RequestVerificationToken"]').val();
    $.ajax({
        url: GetBinListUrl,
        type: 'POST',
        contentType: 'application/json',
        headers: {
            'RequestVerificationToken': token
        },
        data: JSON.stringify({
            PrescriptionNo: prescriptionNo,
            LocationID: LocationElement.val(),
            ItemID: itemId,
            ItemName: itemName,
            EDBatchList: modalData
        }),
        success: function (response) {
            $('#modal-container').html(response.html);
            modalItemList = response.binList
            var modalElement = document.getElementById('binItemModal');
            const myModal = new bootstrap.Modal(modalElement, {
                backdrop: 'static',
                keyboard: false
            });
            myModal.show();

        },
        error: function (xhr, status, error) {
            // Handle error response
            console.error("Error during fetch:", error);
            Swal.fire({
                icon: 'error',
                title: "Error",
                text: `${error}`,
                timer: 3000,
                showConfirmButton: true
            });
        }
    });
}
//#endregion

//#region Modal
function ChangeArrow(element) {
    const icon = element.querySelector('i');
    const isUp = icon.classList.contains('bi-chevron-up');
    if (element.id == "modalCont1") {
        if (isUp) {
            icon.classList.remove('bi-chevron-up');
            icon.classList.add('bi-chevron-down');
        } else {
            icon.classList.remove('bi-chevron-down');
            icon.classList.add('bi-chevron-up');
        }
        return;
    }
    else {
        const modalCont2 = document.getElementById('modalCont2')
        const modalCont3 = document.getElementById('modalCont3')
        const collapse2 = document.querySelector(modalCont2.dataset.bsTarget);
        const collapse3 = document.querySelector(modalCont3.dataset.bsTarget);
        if (isUp) {
            modalCont2.querySelector("i").classList.remove('bi-chevron-up');
            modalCont2.querySelector("i").classList.add('bi-chevron-down');
            modalCont3.querySelector("i").classList.remove('bi-chevron-up');
            modalCont3.querySelector("i").classList.add('bi-chevron-down');
            collapse2.classList.remove('show');
            collapse3.classList.remove('show');
        } else {
            modalCont2.querySelector("i").classList.remove('bi-chevron-down');
            modalCont2.querySelector("i").classList.add('bi-chevron-up');
            modalCont3.querySelector("i").classList.remove('bi-chevron-down');
            modalCont3.querySelector("i").classList.add('bi-chevron-up');
            collapse2.classList.add('show');
            collapse3.classList.add('show');
        }
        return;
    }
}
function LoadBinDetail(element, binID) {
    const binSelection = document.getElementById('binsCollapse')
    const btnBinList = binSelection.querySelectorAll(".selectbin")
    btnBinList.forEach(btn => {
        btn.classList.remove('active')
    })
    element.classList.add('active')
    const itemCollapse = document.getElementById("itemsCollapse")
    const itemList = itemCollapse.querySelector("#itemList")
    const modalfirst = itemList.querySelector(".modalfirst")
    if (modalfirst) modalfirst.remove()

    const SelectedItem = document.getElementById('selectedCollapse').querySelector('#SelectedItem').querySelectorAll('.item-card')

    const template = document.getElementById('itemTemplate')
    itemList.querySelectorAll(".item-card:not(#itemTemplate)").forEach(e => e.remove());
    modalItemList.some(bin => {
        if (bin.binID == binID) {
            bin.binItemLists.forEach(item => {
                const clone = template.cloneNode(true);
                clone.id = `${item.niE_BPOM}-${item.batch}-${item.expiredDate}`;
                clone.dataset.binid = bin.binID
                clone.dataset.binName = bin.binName
                clone.dataset.bpom = item.niE_BPOM
                clone.dataset.batch = item.batch
                clone.dataset.expireddate = item.expiredDate
                clone.classList.remove("d-none");

                clone.querySelector(".bpom").textContent = item.niE_BPOM;
                clone.querySelector(".batch").textContent = item.batch;
                clone.querySelector(".expired").textContent = item.expiredDate;
                clone.querySelector(".qty").textContent = item.quantity;

                const exist = Array.from(SelectedItem).find(card => card.dataset.bpom == item.niE_BPOM &&
                    card.dataset.batch == item.batch &&
                    card.dataset.expireddate == item.expiredDate
                );

                if (exist) {
                    clone.classList.add('selected')
                    clone.querySelector('.d-flex.justify-content-between.align-items-center').classList.add('bg-warning')
                }

                itemList.appendChild(clone);
            });
            return true;
        }
    })
}
function AddToSelectedItem(element) {
    if (element.classList.contains('selected')) return;
    var binId = element.dataset.binid
    var binName = element.dataset.binName
    var bpom = element.dataset.bpom
    var batch = element.dataset.batch
    var expireddate = element.dataset.expireddate
    var SelectedItem = document.getElementById('SelectedItem')
    const html = `<div class="card border border-secondary-subtle shadow-sm">
                                                <div class="card-body py-2 px-3 item-card" data-binid="${binId}" data-bpom="${bpom}"
                                                     data-batch="${batch}" data-expireddate="${expireddate}">
                                                    <div class="d-flex justify-content-between align-items-center">
                                                        <div>
                                                            <div class="fw-bold text-primary">${binName}</div>
                                                            <div class="small text-muted">Nie_BPOM: ${bpom}</div>
                                                            <div class="small text-muted">Batch: ${batch}</div>
                                                            <div class="small text-muted">Exp: ${expireddate}</div>
                                                        </div>

                                                        <div class="d-flex align-items-center gap-2">
                                                            <input type="number" class="form-control form-control-sm qty-input text-end"
                                                                   min="0" value="1" style="width: 80px;">
                                                                <button type="button" class="btn btn-outline-danger btn-sm delete-item"title="Remove item" onclick="RemoveFromSelectedItem(this)">
                                                                    <i class="bi bi-trash"></i>
                                                                </button>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>`
    SelectedItem.insertAdjacentHTML('beforeend', html)

    element.classList.add('selected')
    element.querySelector('.d-flex.justify-content-between.align-items-center').classList.add('bg-warning')
}
function RemoveFromSelectedItem(element) {
    const itemCard = element.closest('.item-card')

    const ItemList = document.getElementById('itemsCollapse').querySelector('#itemList').querySelectorAll('.item-card.selected')
    ItemList.forEach(item => {
        if (item.dataset.bpom == itemCard.dataset.bpom
            && item.dataset.batch == itemCard.dataset.batch
            && item.dataset.expireddate == itemCard.dataset.expireddate) {
            item.classList.remove('selected')
            item.querySelector('.d-flex.justify-content-between.align-items-center.bg-warning').classList.remove('bg-warning')
        }
    })

    const card = element.closest('.card.border');
    card.remove();
}
//#endregion

function saveDatabase(element, prescriptionNo, itemId) {
    const modalFrontEndTotalQty = document.getElementById("modalFrontEndTotalQty")
    const SelectedItems = document.getElementById("SelectedItem");
    const AllQtyInput = SelectedItems.querySelectorAll(".qty-input");
    let TotalQtyInput = new Big(0);
    AllQtyInput.forEach(input => {
        TotalQtyInput = TotalQtyInput.plus(safeBig(input.value))
    })
    const expectedTotal = safeBig(modalFrontEndTotalQty.textContent);
    if (!TotalQtyInput.eq(expectedTotal)) {
        Swal.fire({
            icon: 'error',
            title: 'Error',
            text: 'Total Selected Quantity must equal to Total',
            allowOutsideClick: false,
            allowEscapeKey: false,
            showConfirmButton: true
        });
        return
    }
    let datas = []
    //var locationElement = document.getElementById("LocationSelect")
    var LocationElement = $('#LocationSelect');

    var coll = SelectedItems.querySelectorAll('.item-card')
    coll.forEach(item => {
        let obj = {
            BinID: item.dataset.binid.trim(),
            NIE_BPOM: item.dataset.bpom.trim(),
            Batch: item.dataset.batch.trim(),
            ExpiredDate: item.dataset.expireddate.trim(),
            Qty: item.querySelector(".qty-input").value,
        }
        if (item.classList.contains("front-end-data")) {
            obj.isDB = true
        }
        datas.push(obj)
    })

    let dataChanged = {
        PrescriptionNo: prescriptionNo,
        LocationID: LocationElement.val(),
        ItemID: itemId,
        Datas: datas
    }

    var token = $('input[name="__RequestVerificationToken"]').val();
    $.ajax({
        url: SaveChangedUrl,
        type: 'POST',
        headers: {
            'RequestVerificationToken': token
        },
        contentType: "application/json",
        data: JSON.stringify(dataChanged),
        success: function (response) {
            console.log("OK")
            if (response.success) {
                let itemContainer = document.querySelector(`#card-${itemId}`)
                let detail = itemContainer.querySelector(`.${itemId}-list-detail`)
                detail.innerHTML = response.html;
                const modalEl = document.getElementById("binItemModal");
                const modalInstance = bootstrap.Modal.getInstance(modalEl);
                modalInstance.hide();
            }
            else {
                Swal.fire({
                    icon: 'error',
                    title: 'Failed',
                    text: response.message || 'Save failed, please check your data',
                    showConfirmButton: true
                });
            }
        },
        error: function (xhr, status, error) {
            // Handle error response
            console.error("Error during fetch:", error);
            Swal.fire({
                icon: 'info',
                title: "Error",
                text: `${error}`,
                timer: 5000,
                showConfirmButton: true
            });
        }
    });

    element.disabled = true
}
function ClosePrescription(PrescriptionNo) {
    const prescriptionDetailContainer = document.getElementById("prescriptionDetail");
    let isValid = true;
    let requiredQty = Array.from(prescriptionDetailContainer.querySelectorAll(".required-qty .qty-val"))
    requiredQty.some(a => {
        let val = parseFloat(a.textContent.trim()) || 0
        if (val !== 0) {
            isValid = false
            return true
        }
    })

    if (!isValid) {
        Swal.fire({
            icon: 'warning',
            title: 'Close Prescription Error',
            text: 'Please make sure all required quantities are 0 before close Prescription.'
        });
        return
    }

    $(`.barcode-item[data-barcode='${PrescriptionNo}']`).remove();

    const nextItem = $(".barcode-item").first();
    if (nextItem.length > 0) {
        nextItem.trigger("click");
    }
    else {
        $("#barcodeList").html(`
                                <li class="list-group-item text-muted text-center border-0" id="noBarcodeText">
                                    No scanned barcodes yet
                                </li>
                                `)

        $("#patientDetail").html(`<div class="text-muted text-center">Select a Prescription to view details</div>`)

        $("#prescriptionDetail").html(`<div class="text-muted text-center">Select a barcode to view details</div>`)
    }
}
function safeBig(value) {
    if (value === null || value === undefined || value === "" || (typeof value === "string" && value.trim() === "")) {
        console.log("⚠️ Empty or invalid value:", value);
        return new Big(0);
    }

    try {
        let cleaned = value.toString()
            .replace(/[^\d.-]/g, '')
            .replace(",", ".")

        if (cleaned === "" || isNaN(cleaned)) {
            console.warn("⚠️ Value after cleaning is empty or NaN:", cleaned);
            return new Big(0);
        }

        return new Big(cleaned);
    }
    catch (err) {
        console.error("❌ Failed to parse Big:", value, err);
        return new Big(0);
    }
}