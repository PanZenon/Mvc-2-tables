
window.onload = () => {
    var name = document.getElementById("Name")
    var weight = document.getElementById("Weight")
    var submit = document.getElementById("Submit")


    Validate(name)
    Validate(weight)


    name.onchange = () => {
        Validate(name)
    }
    weight.onchange = () => {
        Validate(weight)
    }
    function Validate(input) {
        var info_id = input.id + "Info"
        if (input.value == "") {
            input.style.background = "red"
            document.getElementById(info_id).innerHTML = "Uzupełnij Dane"
            submit.disabled = true
        }
        else {
            input.style.background = "white"
            document.getElementById(info_id).innerHTML = ''
            submit.disabled = false
        }
    }
}