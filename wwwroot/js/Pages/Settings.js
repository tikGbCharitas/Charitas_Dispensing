// Settings Page JavaScript
// Avicenna Dispensing System

(function () {
    'use strict';

    const Settings = {
        antiForgeryToken: null,
        strings: window.LocalizedStrings || {},

        init: function () {
            this.antiForgeryToken = document.querySelector('#antiForgeryForm input[name="__RequestVerificationToken"]')?.value;
            this.bindEvents();
            this.initPasswordStrength();
        },

        bindEvents: function () {
            // Password Form
            const passwordForm = document.getElementById('passwordForm');
            if (passwordForm) {
                passwordForm.addEventListener('submit', (e) => this.handlePasswordChange(e));
            }

            // Profile Form
            const profileForm = document.getElementById('profileForm');
            if (profileForm) {
                profileForm.addEventListener('submit', (e) => this.handleProfileUpdate(e));
            }

            // Theme Options
            document.querySelectorAll('.theme-option').forEach(option => {
                option.addEventListener('click', (e) => this.handleThemeChange(e));
            });

            // Language Options
            document.querySelectorAll('.language-option').forEach(option => {
                option.addEventListener('click', (e) => this.handleLanguageChange(e));
            });
        },

        initPasswordStrength: function () {
            const newPasswordInput = document.getElementById('newPassword');
            if (newPasswordInput) {
                newPasswordInput.addEventListener('input', (e) => this.checkPasswordStrength(e.target.value));
            }
        },

        checkPasswordStrength: function (password) {
            const strengthBar = document.getElementById('strengthBar');
            const strengthText = document.getElementById('strengthText');

            if (!strengthBar || !strengthText) return;

            if (password.length === 0) {
                strengthBar.className = 'password-strength-bar';
                strengthText.textContent = this.strings.passwordRequirement || 'Password must be at least 6 characters';
                strengthText.style.color = '';
                return;
            }

            let strength = 0;
            if (password.length >= 6) strength++;
            if (password.length >= 10) strength++;
            if (/[a-z]/.test(password) && /[A-Z]/.test(password)) strength++;
            if (/\d/.test(password)) strength++;
            if (/[^a-zA-Z0-9]/.test(password)) strength++;

            strengthBar.className = 'password-strength-bar';
            
            if (strength <= 2) {
                strengthBar.classList.add('strength-weak');
                strengthText.textContent = this.strings.passwordWeak || 'Weak password';
                strengthText.style.color = '#dc3545';
            } else if (strength <= 3) {
                strengthBar.classList.add('strength-medium');
                strengthText.textContent = this.strings.passwordMedium || 'Medium password';
                strengthText.style.color = '#ffc107';
            } else {
                strengthBar.classList.add('strength-strong');
                strengthText.textContent = this.strings.passwordStrong || 'Strong password';
                strengthText.style.color = '#198754';
            }
        },

        handlePasswordChange: async function (e) {
            e.preventDefault();

            const currentPassword = document.getElementById('currentPassword').value;
            const newPassword = document.getElementById('newPassword').value;
            const confirmPassword = document.getElementById('confirmPassword').value;

            if (newPassword !== confirmPassword) {
                this.showAlert('error', 
                    this.strings.passwordMismatch || 'Password Mismatch', 
                    this.strings.passwordMismatchMessage || 'New passwords do not match!');
                return;
            }

            if (newPassword.length < 6) {
                this.showAlert('error', 
                    this.strings.passwordTooShort || 'Password Too Short', 
                    this.strings.passwordTooShortMessage || 'Password must be at least 6 characters long!');
                return;
            }

            const btn = document.getElementById('changePasswordBtn');
            const originalHtml = btn.innerHTML;
            btn.innerHTML = '<span class="loading-spinner"></span> ' + (this.strings.changing || 'Changing...');
            btn.disabled = true;

            try {
                const response = await fetch('/Settings/ChangePassword', {
                    method: 'POST',
                    headers: {
                        'Content-Type': 'application/json',
                        'RequestVerificationToken': this.antiForgeryToken
                    },
                    body: JSON.stringify({
                        currentPassword: currentPassword,
                        newPassword: newPassword,
                        confirmPassword: confirmPassword
                    })
                });

                const result = await response.json();

                if (result.success) {
                    this.showAlert('success', this.strings.success || 'Success!', result.message);
                    document.getElementById('passwordForm').reset();
                    const strengthBar = document.getElementById('strengthBar');
                    const strengthText = document.getElementById('strengthText');
                    strengthBar.className = 'password-strength-bar';
                    strengthText.textContent = this.strings.passwordRequirement || 'Password must be at least 6 characters';
                    strengthText.style.color = '';
                } else {
                    this.showAlert('error', this.strings.error || 'Error', result.message);
                }
            } catch (error) {
                console.error('Error changing password:', error);
                this.showAlert('error', this.strings.error || 'Error', this.strings.errorOccurred || 'An error occurred. Please try again.');
            } finally {
                btn.innerHTML = originalHtml;
                btn.disabled = false;
            }
        },

        handleProfileUpdate: async function (e) {
            e.preventDefault();

            const email = document.getElementById('email').value;

            try {
                const response = await fetch('/Settings/UpdateProfile', {
                    method: 'POST',
                    headers: {
                        'Content-Type': 'application/json',
                        'RequestVerificationToken': this.antiForgeryToken
                    },
                    body: JSON.stringify({
                        Email: email
                    })
                });

                const result = await response.json();

                if (result.success) {
                    this.showAlert('success', this.strings.success || 'Success!', result.message);
                } else {
                    this.showAlert('error', this.strings.error || 'Error', result.message);
                }
            } catch (error) {
                console.error('Error updating profile:', error);
                this.showAlert('error', this.strings.error || 'Error', this.strings.errorOccurred || 'An error occurred. Please try again.');
            }
        },

        handleThemeChange: async function (e) {
            const themeOption = e.currentTarget;
            const theme = themeOption.dataset.theme;

            // Remove active class from all options
            document.querySelectorAll('.theme-option').forEach(opt => {
                opt.classList.remove('active');
            });

            // Add active class to selected option
            themeOption.classList.add('active');

            // Apply theme immediately
            this.applyTheme(theme);

            try {
                const response = await fetch(`/Settings/UpdateTheme?theme=${theme}`, {
                    method: 'GET'
                });

                const result = await response.json();

                if (result.success) {
                    if (typeof Swal !== 'undefined') {
                        Swal.fire({
                            icon: 'success',
                            title: this.strings.themeUpdated || 'Theme Updated!',
                            text: this.strings.themeUpdatedMessage || 'Page will reload to apply changes...',
                            timer: 1500,
                            showConfirmButton: false,
                        });
                    }
                } else {
                    this.showAlert('error', this.strings.error || 'Error', result.message);
                }
            } catch (error) {
                console.error('Error updating theme:', error);
                this.showAlert('error', this.strings.error || 'Error', this.strings.errorOccurred || 'An error occurred. Please try again.');
            }
        },

        handleLanguageChange: async function (e) {
            const languageOption = e.currentTarget;
            const lang = languageOption.dataset.lang;

            // Remove active class from all options
            document.querySelectorAll('.language-option').forEach(opt => {
                opt.classList.remove('active');
            });

            // Add active class to selected option
            languageOption.classList.add('active');

            try {
                const response = await fetch(`/Settings/UpdateLanguage?language=${lang}`, {
                    method: 'GET'
                });

                const result = await response.json();

                if (result.success) {
                    // Reload page to apply localization changes
                    if (result.requiresReload) {
                        if (typeof Swal !== 'undefined') {
                            Swal.fire({
                                icon: 'success',
                                title: lang === 'id' ? (this.strings.languageUpdatedID || 'Bahasa Diperbarui!') : (this.strings.languageUpdated || 'Language Updated!'),
                                text: lang === 'id' ? 
                                    (this.strings.languageReloadMessageID || 'Halaman akan dimuat ulang untuk menerapkan bahasa baru...') :
                                    (this.strings.languageReloadMessage || 'Page will reload to apply the new language...'),
                                timer: 5000,
                                showConfirmButton: false,
                                didClose: () => {
                                    window.location.reload();
                                }
                            });
                        } else {
                            console.log('Language updated, reloading...');
                            setTimeout(() => {
                                window.location.reload();
                            }, 1000);
                        }
                    } else {
                        this.showToast('success', 'Language updated!');
                    }
                } else {
                    this.showAlert('error', this.strings.error || 'Error', result.message);
                }
            } catch (error) {
                console.error('Error updating language:', error);
                this.showAlert('error', this.strings.error || 'Error', this.strings.errorOccurred || 'An error occurred. Please try again.');
            }
        },

        applyTheme: function (theme) {
            const settingsContainer = document.querySelector('.settings-container');
            if (settingsContainer) {
                settingsContainer.setAttribute('data-theme', theme);
            }

            // Trigger global theme manager if available
            if (window.ThemeManager) {
                window.ThemeManager.updateTheme(theme);
            }
        },

        showAlert: function (icon, title, text) {
            if (typeof Swal !== 'undefined') {
                Swal.fire({
                    icon: icon,
                    title: title,
                    text: text,
                    confirmButtonColor: icon === 'success' ? '#198754' : '#dc3545'
                });
            } else {
                alert(`${title}: ${text}`);
            }
        },

        showToast: function (icon, title) {
            if (typeof Swal !== 'undefined') {
                const Toast = Swal.mixin({
                    toast: true,
                    position: 'top-end',
                    showConfirmButton: false,
                    timer: 2000,
                    timerProgressBar: true,
                    didOpen: (toast) => {
                        toast.addEventListener('mouseenter', Swal.stopTimer);
                        toast.addEventListener('mouseleave', Swal.resumeTimer);
                    }
                });

                Toast.fire({
                    icon: icon,
                    title: title
                });
            } else {
                console.log(`${icon}: ${title}`);
            }
        }
    };

    // Initialize on DOM ready
    if (document.readyState === 'loading') {
        document.addEventListener('DOMContentLoaded', function () {
            Settings.init();
        });
    } else {
        Settings.init();
    }

    // Expose to global scope for debugging
    window.SettingsPage = Settings;
})();
