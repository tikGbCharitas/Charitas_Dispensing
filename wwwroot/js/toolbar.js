document.addEventListener('DOMContentLoaded', function () {
    const ToolbarEdit = document.getElementById("btnEdit")
    const ToolbarSave = document.getElementById("btnSave")
    const ToolbarCancel = document.getElementById("btnCancel")

    if (ToolbarEdit) ToolbarEdit.addEventListener("click", onEdit)
    if (ToolbarCancel) ToolbarCancel.addEventListener("click", onCancel)
    if (ToolbarSave) ToolbarSave.addEventListener("click", onSave)
})

let dataToSend = []

// #region Synchronous Toolbar Actions
function onEdit(event) {
    if (typeof onEditConfirmed === "function") {
        onEditConfirmed(event);
    }
    $("#toolbarData").val(JSON.stringify(dataToSend))
}
function onCancel(event) {
    if (typeof onCancelConfirmed === "function") {
        onCancelConfirmed(event);
    }
    $("#toolbarData").val(JSON.stringify(dataToSend))
}
function onSave(event) {
    if (typeof assignDataToSend == "function") {
        //assignDataToSend(event);
        if (!assignDataToSend()) {
            event.preventDefault();
            return;
        }
    }
    if (dataToSend == null || dataToSend.length < 1) {
        event.preventDefault()
        Swal.fire({
            icon: 'warning',
            title: 'No data',
            allowEscapeKey: false,
            allowOutsideClick: false,
            timer: 5000,
            confirmButtonText: 'OK'
        });
        return
    }
    if (typeof onSaveConfirmed === "function") {
        onSaveConfirmed(event);
    }
    $("#toolbarData").val(JSON.stringify(dataToSend));
}
// #endregion

// #region Asynchronous Toolbar Actions

//function onEdit(event) {
//    var token = $('input[name="__RequestVerificationToken"]').val();
//    $.ajax({
//        url: editUrl,
//        type: 'POST',
//        headers: {
//            'RequestVerificationToken': token
//        },
//        success: function (response) {
//            // Handle success response
//            console.log("Edit action confirmed");
//            $('#toolbarContainer').html(response);
//            if (typeof onEditConfirmed === "function") {
//                onEditConfirmed();
//            }
//        },
//        error: function (xhr, status, error) {
//            // Handle error response
//            console.error("Error during edit action:", error);
//            window.location.href = `/Home/HandleAJAXStatusCode?code=${xhr.status}`
//        }
//    });
//}

//function onCancel(event) {
//    var token = $('input[name="__RequestVerificationToken"]').val();
//    var toolbarRequest = $.ajax({
//        url: ToolbarUrl,
//        type: 'GET',
//        headers: {
//            'RequestVerificationToken': token
//        },
//        success: function (response) {
//            // Handle success response
//            console.log("cancelToolbarUrl action confirmed");
//            $('#toolbarContainer').html(response);

//        },
//        error: function (xhr, status, error) {
//            // Handle error response
//            console.error("Error during cancel toolbar action:", error);
//            window.location.href = `/Home/HandleAJAXStatusCode?code=${xhr.status}`
//        }
//    });

//    var collectionRequest = $.ajax({
//        url: cancelUrl,
//        type: 'POST',
//        headers: {
//            'RequestVerificationToken': token
//        },
//        success: function (response) {
//            // Handle success response
//            console.log("cancelCollectionUrl action confirmed");
//            $('#collectionContainer').html(response);
//            if (typeof onCancelConfirmed === "function") {
//                onCancelConfirmed();
//            }
//        },
//        error: function (xhr, status, error) {
//            // Handle error response
//            console.error("Error during cancel collection action:", error);
//            window.location.href = `/Home/HandleAJAXStatusCode?code=${xhr.status}`
//        }
//    });
//    $.when(toolbarRequest, collectionRequest).done(function () {
//        // Both requests are done
//        console.log("Both toolbar and collection actions completed successfully.");
//        if (typeof onCancelConfirmed === "function") {
//            onCancelConfirmed();
//        }
//    });
//}

//function onSave(event) {
//    var token = $('input[name="__RequestVerificationToken"]').val();
//    var jsonData = null

//    if (typeof onSaveConfirmed === "function") {
//        jsonData = onSaveConfirmed();
//    }
//    if (jsonData == null || jsonData == "") return alert("No data to Save")
//    console.log(jsonData);
//    $.ajax({
//        url: saveUrl,
//        type: 'POST',
//        headers: {
//            'RequestVerificationToken': token
//        },
//        data: jsonData,
//        contentType: "application/json; charset=utf-8",
//        success: function (response) {
//            // Handle success response
//            console.log("Save action confirmed");
//        },
//        error: function (xhr, status, error) {
//            // Handle error response
//            console.error("Error during Save action:", error);
//            window.location.href = `/Home/HandleAJAXStatusCode?code=${xhr.status}`
//        }
//    });
//}
// #endregion