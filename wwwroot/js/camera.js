let isCameraOpen = false;
let isCameraBusy = false;
let isProcessing = false;
let scanner = null;


document.addEventListener("DOMContentLoaded", function () {
    const cameraContainer = document.querySelectorAll(".camera-draggable");
    if (cameraContainer) {
        cameraContainer.forEach(makeDraggable)
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
                        {
                            facingMode: "environment"
                        },
                        {
                            fps: 5,
                            qrbox: function (viewfinderWidth, viewfinderHeight) {
                                const minSize = Math.min(viewfinderWidth, viewfinderHeight);
                                return {
                                    width: minSize * 0.8,
                                    height: minSize * 0.8
                                };
                            },
                            //focusMode: "continuous",
                            //advanced: [{ zoom: 2.0 }],
                            // rememberLastUsedCamera: true,
                            //videoConstraints: {
                            //    width: { ideal: 1280 },
                            //    height: { ideal: 720 }
                            //},
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
                                timer: 5000,
                                allowOutsideClick: false,
                                allowEscapeKey: false,
                                showConfirmButton: false,
                                didOpen: () => {
                                    Swal.showLoading();
                                }
                            });

                            decodedText = decodedText.length > 40 ? decodedText.substring(0, 40) : decodedText;

                            const searchTextbox = document.getElementById("searchComponent")
                            if (searchTextbox) {
                                searchTextbox.value = decodedText
                                searchTextbox.dispatchEvent(new KeyboardEvent('keydown', {
                                    key: 'Enter',
                                    which: 13,
                                    keyCode: 13,
                                    bubbles: true
                                }));
                            }
                            else {
                                console.log("searchTextbox not found")
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
                        Swal.close()
                    }).catch(err => {
                        console.error("Start scanner error:", err);
                        Swal.fire({
                            icon: 'error',
                            title: 'Camera Error',
                            timer: 5000,
                            text: err.message || "Failed to open camera",
                            allowOutsideClick: false,
                            allowEscapeKey: false,
                            showConfirmButton: true,
                        });
                        isCameraOpen = false;
                        isCameraBusy = false;
                        isProcessing = false;
                        scanner = null;
                        //btnStartScan.innerHTML = "📷 Open Camera & Scan";
                        btnCamera.innerHTML = "📷";
                        qrContainer.prop("hidden", true);
                    });
                }
            }
        });
        observer.observe(qrElement)
}