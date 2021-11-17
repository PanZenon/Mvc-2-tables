
window.onload = () => {
    var submit = document.getElementById("Submit")
    var Food = document.getElementById("Food")
    var NrCage = document.getElementById("NrCage")



    Validate(Food)
    Validate(NrCage)

    Food.onchange = () => {
        Validate(Food)
    }
    NrCage.onchange = () => {
        Validate(NrCage)
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