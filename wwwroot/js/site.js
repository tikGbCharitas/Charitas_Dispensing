// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


document.addEventListener('DOMContentLoaded', () => {
    const codescan = document.getElementById('codescan')
    if (codescan) {
        $('#codescan').codeScanner(
            {
                maxEntryTime: 400,
                minEntryChars: 20,
                onScan: function ($element, code) {
                    if (typeof ReadScanner === 'function') {
                        ReadScanner($element, code)
                    }
                }
            })
    }
    else {
        console.log("codescan not Found")
    }

    // SERVER-SIDE SEARCH: Handle search input with debounce
    const searchInput = document.getElementById("searchComponent")
    const urlParams = new URLSearchParams(window.location.search);
    const searchQuery = urlParams.get('searchQuery');

    if (searchInput) {
        // Comment out client-side search event listener
        // searchTextbox.addEventListener("input", searchFunction)

        // Note: searchFunction is now handled per page if needed
        // For server-side search, form submission is triggered on input with debounce

        const resultInfo = $("#searchResultInfo");
        const resultCount = $("#searchResultCount");

        if (searchQuery) {
            const count = $("#collectionContainer").find('.card-clickable').length;
            searchInput.value = searchQuery;
            if (resultInfo.length > 0 && resultCount.length > 0) {
                if (searchQuery && searchQuery.trim() !== "") {
                    resultCount.text(`Found ${count} item(s) matching "${searchQuery}"`);
                }
            }

            // Show clear button if it exists
            const clearBtn = document.getElementById('clearSearchButton');
            if (clearBtn) {
                clearBtn.style.display = 'inline-block';
            }
        }
        else {
            const LocID = urlParams.get('LocID'); 
            if (LocID) {
                resultCount.text(`Showing 100 item(s) nearest Expired Date`);
            }
        }
    }

    const LocationSelection = document.getElementById("selectLocation");
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

        // Auto-focus on search box when dropdown opens (Desktop & Mobile)
        $('#selectLocation').on('select2:open', function (e) {
            // Small delay to ensure dropdown is rendered
            setTimeout(function () {
                // Find the search input in the dropdown
                const searchField = document.querySelector('.select2-search__field');
                if (searchField) {
                    searchField.focus();
                }
            }, 50);
        });

        $('#selectLocation').on('select2:select', function (e) {
            const form = $(this).closest('form');
            if (form.length > 0) {
                form.submit();
            }
        });
    }
});

// Idle Detection & Auto-Logout Configuration
(function() {
    'use strict';
    
    // Helper function to get cookie value by name
    function getCookie(name) {
        const value = `; ${document.cookie}`;
        const parts = value.split(`; ${name}=`);
        if (parts.length === 2) return parts.pop().split(';').shift();
        return null;
    }
    
    // Check if user has Remember Me enabled by checking dedicated RememberMe cookie
    // This cookie is only set when user explicitly checks "Remember Me" during login 
    const rememberMeEnabled = getCookie('AvicennaDispensingRememberMe') === 'true';
    
    if (rememberMeEnabled) {
        return; // Disable idle detection if Remember Me is set
    }
    
    // 30 minutes for session-only users (Remember Me users skip this entire block)
    const IDLE_TIMEOUT = 30 * 60 * 1000;
    const WARNING_TIMEOUT = IDLE_TIMEOUT - (2 * 60 * 1000); // 2 minutes before timeout
    
    let idleTimer = null;
    let warningTimer = null;
    let warningModal = null;
    
    // Events that reset the idle timer
    const resetEvents = ['mousedown', 'mousemove', 'keypress', 'scroll', 'touchstart', 'click'];
    
    function resetIdleTimer() {
        // Clear existing timers
        if (idleTimer) clearTimeout(idleTimer);
        if (warningTimer) clearTimeout(warningTimer);
        
        // Close warning if it's showing
        if (warningModal) {
            Swal.close();
            warningModal = null;
        }
        
        // Set warning timer
        warningTimer = setTimeout(showIdleWarning, WARNING_TIMEOUT);
        
        // Set logout timer
        idleTimer = setTimeout(autoLogout, IDLE_TIMEOUT);
    }
    
    function showIdleWarning() {
        const warningSeconds = Math.floor((IDLE_TIMEOUT - WARNING_TIMEOUT) / 1000);
        let countdown = warningSeconds;
        
        if (typeof Swal !== 'undefined') {
            warningModal = Swal.fire({
                icon: 'warning',
                title: 'Session Timeout Warning',
                html: `You will be logged out in <b>${countdown}</b> seconds due to inactivity.<br><br>Click "Stay Logged In" to continue your session.`,
                timer: warningSeconds * 1000,
                timerProgressBar: true,
                showCancelButton: true,
                confirmButtonText: 'Stay Logged In',
                cancelButtonText: 'Logout Now',
                allowOutsideClick: false,
                didOpen: () => {
                    const timer = Swal.getPopup().querySelector('b');
                    const interval = setInterval(() => {
                        countdown--;
                        timer.textContent = countdown;
                        
                        if (countdown <= 0) {
                            clearInterval(interval);
                        }
                    }, 1000);
                }
            }).then((result) => {
                if (result.isConfirmed) {
                    // User clicked "Stay Logged In"
                    resetIdleTimer();
                } else if (result.dismiss === Swal.DismissReason.cancel) {
                    // User clicked "Logout Now"
                    autoLogout();
                } else if (result.dismiss === Swal.DismissReason.timer) {
                    // Timer expired
                    autoLogout();
                }
            });
        } else {
            // Fallback if SweetAlert not available
            if (confirm(`You will be logged out in ${countdown} seconds due to inactivity. Click OK to stay logged in.`)) {
                resetIdleTimer();
            } else {
                autoLogout();
            }
        }
    }
    
    function autoLogout() {
        // Clear timers
        if (idleTimer) clearTimeout(idleTimer);
        if (warningTimer) clearTimeout(warningTimer);
        
        // Show logout message
        if (typeof Swal !== 'undefined') {
            Swal.fire({
                icon: 'info',
                title: 'Session Expired',
                text: 'You have been logged out due to inactivity.',
                timer: 5000,
                timerProgressBar: true,
                showConfirmButton: false,
                allowOutsideClick: false,
                didClose: () => {
                    performLogout();
                }
            });
        } else {
            alert('You have been logged out due to inactivity.');
            performLogout();
        }
    }
    
    function performLogout() {
        // Submit the logout form
        const logoutForm = document.querySelector('form[action*="Logout"]');
        if (logoutForm) {
            logoutForm.submit();
        } else {
            // Fallback: redirect to logout URL
            window.location.href = '/Login/Index';
        }
    }
    
    // Initialize idle detection on authenticated pages only
    function initIdleDetection() {
        // Check if user is authenticated (logout button exists)
        const logoutButton = document.querySelector('button[type="submit"][class*="dropdown-item"]');
        
        if (logoutButton) {
            const timeoutMinutes = Math.floor(IDLE_TIMEOUT / 60000);
            
            // Attach event listeners
            resetEvents.forEach(event => {
                document.addEventListener(event, resetIdleTimer, true);
            });
            
            // Start the timer
            resetIdleTimer();
        }
    }
    
    // Initialize when DOM is ready
    if (document.readyState === 'loading') {
        document.addEventListener('DOMContentLoaded', initIdleDetection);
    } else {
        initIdleDetection();
    }
})();