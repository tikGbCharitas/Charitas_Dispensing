let isCameraOpen = false; let isCameraBusy = false; let isProcessing = false;

document.addEventListener("DOMContentLoaded", function () {
    document.querySelectorAll("button[id^='btnbinList-']").forEach(button => {
        button.addEventListener("click", binClickActive)
    })
    document.getElementById("btnAddToList").addEventListener("click", AddItemtoList)
    document.getElementById("btnChooseEDBatchManually").addEventListener("click", openModalChooseEDBatchManually)    
})
document.querySelectorAll('.camera-draggable').forEach(makeDraggable);
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
        if (isDragging) {
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
                            useBarCodeDetectorIfSupported: true
                        }
                    },
                    (decodedText) => {
                        if (isProcessing) return
                        isProcessing = true;
                        Swal.fire({
                            icon: 'success',
                            title: '✅ Barcode berhasil discan!',
                            text: 'Processing barcode...',
                            allowOutsideClick: false,
                            allowEscapeKey: false,
                            showConfirmButton: false,
                            didOpen: () => {
                                Swal.showLoading();
                            }
                        });
                        let ScannedType = decodedText.length;
                        if (ScannedType <= 10) {
                            if (ScannedType === 10 && /^\d+$/.test(decodedText.trim())) {
                                let Branch = decodedText.substring(0, 1)
                                let dateReg = decodedText.substring(2, 3)
                                let TransSeq = decodedText.substring(4, 7)

                                let getYear = new Date().getFullYear().substring(2);
                                let getMonth = lString(new Date().getMonth() + 1).padStart(2, '0')

                                let RegType = dateReg > 50 ? "PM" : "OP"
                                let RegNo = `REG/${RegType}/${getYear}${getMonth}${dateReg}-${TransSeq}`
                                document.getElementById("inputRegNo").value = RegNo
                                CheckRegNo(RegNo)
                            }
                            else {
                                binScanActive(decodedText.trim());
                            }
                        }
                        else if (ScannedType == 13) {
                            let TransactionID = "";
                            let TransactionNo1 = decodedText.substring(2, 8)
                            let TransactionNo2 = decodedText.substring(8)
                            switch (decodedText.substring(0, 1)) {
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
                                //CheckScannedData(TransactioNo, decodedText);
                            }
                        }
                        else if (ScannedType > 40) {
                            let NIE_BPOM = decodedText.substring(2, 17);
                            let Batch_No = decodedText.substring(19, 26);
                            let Exp_Date = decodedText.substring(28, 34);
                            let SerialNumber = decodedText.substring(36,);

                            let day = Exp_Date.substring(0, 2);
                            let month = Exp_Date.substring(2, 4);
                            let year = currrentTime + Exp_Date.substring(4, 6);
                            let ED_Format = `${year}-${month}-${day}`;

                            document.getElementById("inputNIEBPOM").value = NIE_BPOM
                            document.getElementById("inputBatch").value = Batch_No
                            document.getElementById("inputExpiredDate").value = ED_Format
                            document.getElementById("inputQuantity").value = 1
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
                }).catch(err => {
                    console.error("Start scanner error:", err);
                    Swal.fire({
                        icon: 'error',
                        title: 'Camera Error',
                        text: err.message || "Failed to open camera"
                    });
                    isCameraOpen = false;
                    isCameraBusy = false;
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
function binScanActive(binName) {
    let binID;
    document.querySelectorAll("button[id^='btnbinList-']").forEach(button => {
        if (button.value.trim() === binName) {
            button.classList.add("active", "bg-info")
            binID = button.dataset.binId
            document.getElementById("SelectedBin").value = binName
        }
        else {
            button.classList.remove("active", "bg-info")
        }
    })
    //getBinItem(binID.trim())
}
function binClickActive(event) {
    let binID = event.target.dataset.binId;
    document.querySelectorAll("button[id^='btnbinList-']").forEach(button => {
        button.classList.remove("active", "bg-info")
    })
    event.target.classList.add("active", "bg-info")
    document.getElementById("SelectedBin").value = event.target.value
    //getBinItem(binID.trim())
}
function openModalChooseEDBatchManually() {
    const btnActive = document.querySelector("#binList button.active");

    if (!btnActive) {
        Swal.fire({
            icon: 'warning',
            title: '⚠ Bin Error',
            text: 'Please choose bin.',
            showConfirmButton: true
        });
        return;
    }
    getBinItem(btnActive.dataset.binId)
}
function CheckRegNo(RegistrationNo) {
    var token = $('input[name="__RequestVerificationToken"]').val();

    isProcessing = true;
    Swal.fire({
        icon: 'success',
        title: '✅ Checking Registartion No',
        text: 'Processing...',
        allowOutsideClick: false,
        allowEscapeKey: false,
        showConfirmButton: false,
        didOpen: () => {
            Swal.showLoading();
        }
    });

    $.ajax({
        url: getRegNoUrl,
        method: "POST",
        headers: {
            'RequestVerificationToken': token
        },
        data: { RegistrationNo: RegistrationNo },
        success: function (response) {
            Swal.close();
            isProcessing = false;
            if (response.success) {
                let patientName = (response.data.patient.firstName + response.data.patient.middleName + response.data.patient.lastName).trim()
                $("#inputPatientName").val(patientName)
                $("#inputMedicalNo").val(response.data.patient.medicalNo)
                $("#inputParamedicName").val(response.data.paramedicName)
            }
            else {
                Swal.fire({
                    icon: 'error',
                    title: 'ERROR',
                    text: 'RegistrationNo not exist on DB',
                    showConfirmButton: true,
                    confirmButtonText: 'OK'
                })
            }
        },
        error: function (xhr) {
            Swal.close();
            setTimeout(() => {
                Swal.fire({
                    icon: 'error',
                    title: 'Oops...',
                    text: 'Failed to Item from Database.'
                }).then(() => {
                    isProcessing = false;
                    console.error("AJAX error: " + xhr);
                });
            }, 100);
        }
    })
}
function getBinItem(binID) {
    if (isProcessing) return

    var token = $('input[name="__RequestVerificationToken"]').val();

    isProcessing = true;
    Swal.fire({
        icon: 'success',
        title: '✅ Checking Bin Item',
        text: 'Processing...',
        allowOutsideClick: false,
        allowEscapeKey: false,
        showConfirmButton: false,
        didOpen: () => {
            Swal.showLoading();
        }
    });

    $.ajax({
        url: getBinItemUrl,
        method: "POST",
        headers: {
            'RequestVerificationToken': token
        },
        data: { BinID: binID },
        success: function (response) {
            Swal.close();
            isProcessing = false;
            $('#ModalChooseEDBatchManually .modal-body').html(response);
            const modalEl = document.getElementById('ModalChooseEDBatchManually');
            const modal = new bootstrap.Modal(modalEl);
            document.querySelector("#ModalChooseEDBatchManually button.savedModal").addEventListener("click", saveModal)
            document.querySelectorAll("#ModalChooseEDBatchManually button.closeModal").forEach(button => {
                button.addEventListener("click", closeModal)
            })
            document.querySelectorAll("#ModalChooseEDBatchManually .card-clickable").forEach(card => {
                card.addEventListener("click", SelectedEDBatch)
            })    
            modal.show();

        //    Swal.fire({
        //        icon: 'success',
        //        title: 'Barcode scanned!',
        //        text: `PrescriptionNo: ${TransactionNo}`,
        //        timer: 1500,
        //        showConfirmButton: false
            //})
        },
        error: function (xhr) {
            Swal.close();
            setTimeout(() => {
                Swal.fire({
                    icon: 'error',
                    title: 'Oops...',
                    text: 'Failed to Item from Database.'
                }).then(() => {
                    isProcessing = false;
                    console.error("AJAX error: " + xhr);
                });
            }, 100);
        }
    })
}
function SelectedEDBatch(event) {
    let isSameCard = false
    if(event.currentTarget.classList.contains("card-active")) isSameCard = true
    document.querySelectorAll("#ModalChooseEDBatchManually .card-clickable").forEach(card => {
        card.classList.remove("card-active", "bg-warning")
    })
    if(!isSameCard) event.currentTarget.classList.add("card-active", "bg-warning")
}
function closeModal() {
    document.activeElement.blur();

    const modalEl = document.getElementById('ModalChooseEDBatchManually');
    const modalInstance = bootstrap.Modal.getInstance(modalEl);
    modalInstance.hide();
}
function saveModal() {
    let ItemID = document.getElementById("modalItemID").textContent
    let NIE_BPOM = document.getElementById("modalNIEBPOM").textContent
    let Batch = document.getElementById("modalBatch").textContent
    let ExpiredDate = document.getElementById("modalExpiredDate").textContent
    let Qty = document.getElementById("modalQty").textContent

    document.activeElement.blur();
    const modalEl = document.getElementById('ModalChooseEDBatchManually');
    const modalInstance = bootstrap.Modal.getInstance(modalEl);
    modalInstance.hide();

    document.getElementById("inputItemID").value = ItemID
    document.getElementById("inputNIEBPOM").value = NIE_BPOM
    document.getElementById("inputBatch").value = Batch
    document.getElementById("inputExpiredDate").value = ExpiredDate
    document.getElementById("inputQuantity").value = 1
}
function AddItemtoList(event) {
    let itemId = document.getElementById("inputItemID").value.trim()
    let nieBpom = document.getElementById("inputNIEBPOM").value.trim()
    let batch = document.getElementById("inputBatch").value.trim()
    let ED = document.getElementById("inputExpiredDate").value.trim()
    let Qty = document.getElementById("inputQuantity").value

    if (!itemId || !nieBpom || !batch || !ED || isNaN(parseFloat(Qty)) || parseFloat(Qty) <= 0) {
        Swal.fire({
            icon: 'error',
            title: 'ERROR',
            text: 'Detail cannot be empty and Quantity must be greater than 0',
            showConfirmButton: true,
            confirmButtonText: 'OK'
        })
        return
    }

    let noItemDiv = document.getElementById("NoItemList");
    if (noItemDiv) {
        noItemDiv.remove();
    }
    let newCard = `
                    <div class="col">
                        <div class="card-body card-send-clickable mt-3 border border-secondary" data-is-modified="false"
                                data-item-id="${itemId}" data-nie-bpom="${nieBpom}" data-batch-id="${batch}" data-expired-date="${ED}">
                            <h5 class="card-title fw-bold">${itemId}</h5>
                            <ul class="list-unstyled mb-0">
                                <li><strong>🆔 ItemID: </strong><span id="sendItemID">${itemId}</span></li>
                                <li><strong>🔖 NIE BPOM: </strong><span id="sendNIEBPOM">${nieBpom}</span></li>
                                <li><strong>📦 Batch: </strong><span id="sendBatch">${batch}</span></li>
                                <li><strong>📅 Expired: </strong><span id="sendExpiredDate">${ED}</span></li>
                                <li><strong>📊 Qty: </strong><span id="sendQty">${Qty}</span></li>
                            </ul>
                        </div>
                    </div>
                    `
    const itemListRow = document.querySelector("#itemList .row");
    const isFirstItem = itemListRow.children.length === 0;
    itemListRow.insertAdjacentHTML("beforeend", newCard)
    if (isFirstItem) {
        let collapseElement = document.getElementById("collapseItemList");
        let collapseInstance = new bootstrap.Collapse(collapseElement, { show: true });
    }
}