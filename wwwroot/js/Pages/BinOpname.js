let binList = []

document.addEventListener("DOMContentLoaded", function () {
    const formDateFilter = document.getElementById("formDateFilter")
    if(formDateFilter) formDateFilter.addEventListener("submit", dateFilterValidation)

    document.querySelectorAll("#btnDetailTransaction").forEach(button => {
        button.addEventListener("click", goToDetailPage)
    })

    document.querySelectorAll("input[name='filterOption']").forEach(radio => {
        radio.addEventListener("change", function () {
            Swal.fire({
                title: 'Fetching Data',
                text: 'Please wait...',
                allowEscapeKey: false,
                allowOutsideClick: false,
                didOpen: () => {
                    Swal.showLoading();
                }
            });
            if (this.checked) document.getElementById("filterForm").submit()
        })
    })

    document.querySelectorAll("button[id^='Detail-']").forEach(button => {
        button.addEventListener("click", getTransactionDetail)
    })

    document.querySelectorAll('#btnAddNewBIn').forEach(button => {
        button.addEventListener("click", getBinList)
    })

    document.querySelectorAll('#btnAddNewEDBatch').forEach(button => {
        button.addEventListener("click", showModal)
    })

    document.querySelectorAll('.qty-userinput').forEach(input => {
        input.addEventListener("keydown", rejectNonNumber)
        input.addEventListener("change", qtyValidation)
    })

    document.querySelectorAll('#btnSaveModal').forEach(button => {
        button.addEventListener("click", updateValueModal)
    })

    //const PageDetail = document.querySelector('#PageDetail')
    //if (PageDetail) {
    //    console.log(detailList)
    //    dataToSend = detailList
    //}
})
function rejectNonNumber(event) {
    const allowedKeys = [
        "Backspace", "Delete", "ArrowLeft", "ArrowRight", "Tab", "Home", "End"
    ];

    const isNumber = event.key >= "0" && event.key <= "9";
    const isDot = event.key === ".";

    if (!isNumber && !isDot && !allowedKeys.includes(event.key)) {
        event.preventDefault();
    }

    if (isDot && event.target.value.includes(".")) {
        event.preventDefault();
    }

    let inputValue = event.target.value;

    // Allow only one dot
    if (isDot && inputValue.includes(".")) {
        event.preventDefault();
    }
}
function qtyValidation(event){
    let value = parseFloat(event.target.value)
    if (!isNaN(value)) {
        event.target.value = value.toFixed(2);
    }
    else if (value < 0) {
        event.target.value = 0
    }
    else {
        event.target.value = 0
    }
}
function showModal(event) {
    let value = event.target.value
    let itemId = event.target.dataset.itemId
    let cardElement = event.target.closest(".card")
    if (value == "edbatch") {
        let modalElement = document.getElementById('modaladdNewEDBatch')
        modalElement.setAttribute('data-item-id', itemId)
        modalElement.relatedCard = cardElement
        let modal = new bootstrap.Modal(modalElement)
        modal.show()
    }
    else if (value == "bin") {
        let modalElement = document.getElementById('modaladdNewBin')
        populateBinList();
        modalElement.setAttribute('data-item-id', itemId)
        modalElement.relatedCard = cardElement
        let modal = new bootstrap.Modal(modalElement)
        modal.show()
    }
}
function populateBinList() {
    const select = document.getElementById("BinSelect")
    let optionsHtml = '<option value="">-- Select Bin --</option>';

    binList.forEach(bin => {
        optionsHtml += `<option value="${bin.binID}">${bin.binName}</option>`;
    });

    select.innerHTML = optionsHtml;
}
function updateValueModal(event) {
    let modalElement = event.target.closest(".modal")
    let itemID = modalElement.getAttribute('data-item-id')
    let cardElement = modalElement.relatedCard;

    let modalshown = event.target.value
    if (modalshown == "bin") {
        let form = modalElement.querySelector("#modalFormNewBin");

        if (!form.checkValidity()) {
            form.reportValidity();
            return;
        }
        let userSelection = modalElement.querySelector('#BinSelect').selectedOptions[0].text;
        let userQty = modalElement.querySelector("#Quantity").value
        let binListContainer = cardElement.querySelector('.binlist');
        let newLineHtml = `
                            <div class="binItem">
                                <div>📍 <strong>Bin: </strong> <span class="binName">${userSelection}</span></div>
                                <div class="d-flex align-items-center gap-2">
                                    <span class="fw-bold mb-0">📊 Bin Qty: </span>
                                    <input type="number" min="0"
                                            class="form-control form-control-sm w-25 qty-userinput binQty"
                                            style="height: calc(1.5em + .5rem + 2px); min-width: 80px;"
                                            value="${userQty}" />
                                </div>
                            </div>
                            `
        binListContainer.insertAdjacentHTML("beforeend", newLineHtml);
        form.reset();
    }
    else if (modalshown == "edbatch") {
        let form = modalElement.querySelector("#modalFormEDBatch");

        if (!form.checkValidity()) {
            form.reportValidity();
            return;
        }

        let userBPOM = document.querySelector('#NIEBPOM').value
        let userBatch = document.querySelector('#Batch').value
        let userExpiredDate = document.querySelector('#ExpiredDate').value
        let userQty = document.querySelector('#Quantity').value

        let edbatchListContainer = cardElement.querySelectorAll('.edbatchlist');
        let lastEdbatchList = edbatchListContainer[edbatchListContainer.length - 1];
        let newLineHtml =  `<div class="mb-3 px-3 edbatchlist" style="background-color: lightgreen">
                                <ul class="list-unstyled small">
                                    <li>🔖 <strong>NIE BPOM:</strong> <span class="NIE_BPOM">${userBPOM}</span></li>
                                    <li>📦 <strong>Batch:</strong> <span class="batch">${userBatch}</span></li>
                                    <li>📅 <strong>Expired:</strong> <span class="expireddate">${userExpiredDate}</span></li>
                                </ul>
                                <hr />
                                <div class="d-flex align-items-center gap-3">
                                    <p class="mb-0 fw-bold">In Box: </p>
                                    <input type="number" class="form-control form-control-sm w-25 qty-userinput inBoxQuantity" min="0" value="${userQty}" style=" height: calc(1.5em + .5rem + 2px); min-width: 80px;" />
                                </div>
                                <p class="fw-bold text-end text-success">
                                    Total: ${userQty}
                                </p>
                            </div>
                            `
        lastEdbatchList.insertAdjacentHTML("afterend", newLineHtml)
        form.reset();
    }
    // ✅ Close modal after adding
    let modalInstance = bootstrap.Modal.getInstance(modalElement);
    if (modalInstance) modalInstance.hide();
}
function dateFilterValidation(event) {
    let startDate = new Date(document.getElementById("StartDate").value)
    let endDate = new Date(document.getElementById("EndDate").value)
    if (startDate && endDate && endDate < startDate) {
        event.preventDefault()
        Swal.fire({
            icon: 'error',
            title: 'Date Error',
            text: 'To Date cannot be earlier than From Date',
            allowOutsideClick: false,
            allowEscapeKey: false,
            timer: 3000,
            showConfirmButton: true
        })
    }
}
function goToDetailPage(event) {
    Swal.fire({
        icon: 'info',
        text: 'Please wait...',
        allowOutsideClick: false,
        allowEscapeKey: false,
        didOpen: () => {
            Swal.showLoading()
        }
    })
}
function getTransactionDetail(event) {
    Swal.fire({
        title: 'Fetching Data',
        text: 'Please wait... we are getting the lastest Balance',
        allowOutsideClick: false,
        allowEscapeKey: false,
        didOpen: () => {
            Swal.showLoading()
        }
    })
    const TransactionNo = event.target.dataset.transaction
    const SortID = event.target.dataset.sortid;
    const SortSelection = document.querySelector('input[name="filterOption"]:checked').value
    $.ajax({
        url: TransactionPageDetailUrl,
        type: 'POST',
        data: {
            TransactionNo: TransactionNo,
            SortID: SortID,
            SortSelection: SortSelection,
            DataMode: dataMode
        }, 
        success: function (response) {
            document.querySelectorAll('[id^="Detail-"]').forEach(button => {
                button.classList.remove("active")
            })
            event.target.classList.add("active")
            Swal.close();
            $('#PageDetail').html(response)
        },
        error: function (xhr, status, error) {
            Swal.close()
            Swal.fire({
                icon: 'error',
                title: "Error",
                text: `${error}`,
                timer: 1000,
                allowOutsideClick: false,
                allowEscapeKey: false,
                showConfirmButton: true
            })
        }
    })
}
function getBinList(event) {
    let TransactionNo = event.target.dataset.transactionNo
    if (binList.length == 0) {
        $.ajax({
            url: BinListUrl,
            data: { TransactionNo: TransactionNo},
            type: "POST",
            success: function (response) {
                if (response.success) {
                    binList = response.data
                    showModal(event)
                }
            },
            error: function (xhr, status, error) {
                Swal.fire({
                    icon: 'error',
                    title: "Error",
                    text: `${error}`,
                    timer: 1000,
                    allowOutsideClick: false,
                    allowEscapeKey: false,
                    showConfirmButton: true
                })
            }
        })
    }
    else {
        showModal(event);
    }
}
function onEditConfirmed(event) {
    let activePage = document.querySelector('[id^="Detail-"].active')
    if (!activePage) {
        Swal.fire({
            icon: 'info',
            text: 'Please have at least one active Page or Bin Name',
            timer: 1500,
            allowEscapeKey: false,
            allowOutsideClick: false,
            showConfirmButton: true
        })
        event.preventDefault()
        return
    }
    else if (activePage.dataset.isapproved === "True") {
        Swal.fire({
            icon: 'info',
            text: 'This Page has been approved',
            timer: 1500,
            allowEscapeKey: false,
            allowOutsideClick: false,
            showConfirmButton: true
        })
        event.preventDefault()
        return
    }
    const SortSelection = document.querySelector('input[name="filterOption"]:checked').value
    const SortID = activePage.dataset.sortid
    const TransactionNo = activePage.dataset.transaction
    $('#toolbarData').val(`${TransactionNo}|${SortSelection}|${SortID}`)
}
function onCancelConfirmed() {
    const SortSelection = document.querySelector('input[name="filterOption"]:checked').value
    let activePage = document.querySelector('[id^="Detail-"].active')
    const SortID = activePage.dataset.sortid
    const TransactionNo = activePage.dataset.transaction
    $('#toolbarData').val(`${TransactionNo}|${SortSelection}|${SortID}`)
}
function assignDataToSend() {
    let datas = []
    let totalQuantity = 0
    const TransactionNo = document.querySelector('#lblTransactionNo').textContent

    const cardList = document.querySelectorAll('.card .card-body')
    cardList.forEach(card => {
        let itemID = card.querySelector("#cardItemID").textContent.trim()
        let edbatchList = card.querySelectorAll(".edbatchlist")
        if (edbatchList.length > 0) {
            edbatchList.forEach(edbatch => {
                let nieBpom = edbatch.querySelector(".NIE_BPOM").textContent.trim()
                let batch = edbatch.querySelector(".batch").textContent.trim()
                let expiredDate = edbatch.querySelector(".expireddate").textContent
                let binList = edbatch.querySelector(".binlist")
                if (binList) {
                    let inBoxQuantity = parseFloat(edbatch.querySelector(".inBoxQuantity").value)
                    let binItemList = binList.querySelectorAll(".binItem")
                    let binListTotalQty = Array.from(binItemList)
                        .reduce((sum, el) => {
                            let qtyInput = el.querySelector('.binQty');
                            let qty = qtyInput ? parseFloat(qtyInput.value) || 0 : 0;
                            return sum + qty;
                        }, 0);
                    totalQuantity = inBoxQuantity + binListTotalQty

                    binItemList.forEach(bin => {
                        let binName = bin.querySelector('.binName').textContent
                        let binQty = bin.querySelector('.binQty').value
                        pushToArrayDatas(datas, itemID, totalQuantity.toFixed(2), nieBpom, batch, expiredDate, binName, binQty)
                    })
                }
                else {
                    totalQuantity = edbatch.querySelector(".inBoxQuantity").value
                    pushToArrayDatas(datas, itemID, totalQuantity, nieBpom, batch, expiredDate)
                }
            })
        }
        else {
            totalQuantity = card.querySelector(".totalQuantity").value
            pushToArrayDatas(datas, itemID, totalQuantity)
        }
    })

    dataToSend = {
        TransactionNo: TransactionNo,
        Datas: datas
    }
    console.log(dataToSend)
    console.log("done")
}
function pushToArrayDatas(datas, itemId, totalQty, nieBpom = "", batch = "", expiredDate = "", binName = "", binQty = "0") {
    datas.push({
        itemId,
        totalQty,
        nieBpom,
        batch,
        expiredDate,
        binName,
        binQty
    });
}