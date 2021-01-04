// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const fileUploadInputId = 'fileInput';
const fileUploadInput = document.getElementById(fileUploadInputId);

const submitButtonId = 'submitButton';
const submitButton = document.getElementById(submitButtonId);

if (submitButton != null) {
    submitButton.enabled = false;
}

if (fileUploadInput != null) {

    fileUploadInput.oninput += () => {
        submitButton.enabled = true;
    }
}
