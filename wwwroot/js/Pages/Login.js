document.addEventListener("DOMContentLoaded", () => {
    document.getElementById('loginForm').addEventListener('submit', function () {
        var checkbox = document.getElementById('rememberMe').checked;
        document.getElementById("rememberMeValue").value = checkbox
    });

    document.getElementById('devLoginForm').addEventListener('submit', function () {
        var rememberMeChecked = document.getElementById('rememberMe').checked;
        document.getElementById('devRememberMeValue').value = rememberMeChecked;
    });
})