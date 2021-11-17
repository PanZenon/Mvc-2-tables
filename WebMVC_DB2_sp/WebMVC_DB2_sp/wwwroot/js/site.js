// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
window.onload = () => {
    var arrows = document.getElementsByClassName("fa-arrow-down");
    for (var i = 0; i < arrows.length; i++) {
        arrows[i].addEventListener('click', ToggleDisplay)
        var id = arrows[i].parentElement.className;
        id = id.split(" ")
        arrows[i].id = id[0]
    }
}

function ToggleDisplay(id) {
    var animals = document.getElementsByClassName("animal." + id.currentTarget.id)
    for (var i = 0; i < animals.length; i++) {
        animals[i].classList.toggle("hidden")
    }
}