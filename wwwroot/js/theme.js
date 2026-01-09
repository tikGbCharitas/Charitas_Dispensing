// Theme management for Avicenna Dispensing
(function () {
    'use strict';

    const ThemeManager = {
        mediaQuery: null,

        init: function () {
            this.mediaQuery = window.matchMedia('(prefers-color-scheme: light)');
            this.applyTheme();
            this.setupThemeObserver();
        },

        applyTheme: function () {
            const theme = this.getTheme();
            const actualTheme = this.resolveTheme(theme);
            this.setTheme(actualTheme);
        },

        getTheme: function () {
            // Check cookie
            const cookies = document.cookie.split('; ');
            const themeCookie = cookies.find(row => row.startsWith('UserTheme='));
            
            if (themeCookie) {
                return themeCookie.split('=')[1];
            }

            // Default to light
            return 'light';
        },

        resolveTheme: function (theme) {
            if (theme === 'auto') {
                return this.getSystemTheme();
            }
            return theme;
        },

        getSystemTheme: function () {
            return this.mediaQuery && this.mediaQuery.matches ? 'dark' : 'light';
        },

        setTheme: function (theme) {
            const elements = [
                document.documentElement,
                document.body
            ];

            elements.forEach(element => {
                if (element) {
                    element.setAttribute('data-theme', theme);
                }
            });

            // Also set on settings container if exists
            const settingsContainer = document.querySelector('.settings-container');
            if (settingsContainer) {
                settingsContainer.setAttribute('data-theme', theme);
            }
        },

        setupThemeObserver: function () {
            const currentTheme = this.getTheme();
            
            // Listen for system theme changes if auto mode
            if (currentTheme === 'auto' && this.mediaQuery) {
                // Use addEventListener instead of deprecated addListener
                this.mediaQuery.addEventListener('change', (e) => {
                    const newTheme = e.matches ? 'dark' : 'light';
                    this.setTheme(newTheme);
                });
            }
        },

        // Public method to update theme (called from Settings page)
        updateTheme: function (theme) {
            const actualTheme = this.resolveTheme(theme);
            this.setTheme(actualTheme);
            
            // Re-setup observer if switching to auto
            if (theme === 'auto') {
                this.setupThemeObserver();
            }
        }
    };

    // Initialize on DOM ready
    if (document.readyState === 'loading') {
        document.addEventListener('DOMContentLoaded', function () {
            ThemeManager.init();
        });
    } else {
        ThemeManager.init();
    }

    // Expose to global scope for use in other scripts
    window.ThemeManager = ThemeManager;
})();
