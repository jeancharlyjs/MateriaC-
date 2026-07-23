document.addEventListener("DOMContentLoaded", () => {
    const firstInvalid = document.querySelector(".input-validation-error");

    if (firstInvalid instanceof HTMLElement) {
        firstInvalid.focus();
    }
});
