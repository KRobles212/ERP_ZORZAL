﻿$("#fact_AlCredito").change(function () {
    if (this.checked) {
        //Do stuff
        console.log("Hola");
        $('#Credito').show();
    }
    else {

        $('#Credito').hide();
    }
});

$("#fact_AlCredito").ready(function () {
    if (this.checked) {
        //Do stuff
        console.log("Hola");
        $('#Credito').show();
    }
    else {

        $('#Credito').hide();
    }
});
$("#fact_AlCredito").change(function () {
    if (this.checked) {
        //Do stuff
        console.log("Hola");
        $('#Credito1').show();
    }
    else {

        $('#Credito1').hide();
    }
});

$("#fact_AlCredito").ready(function () {
    if (this.checked) {
        //Do stuff
        console.log("Hola");
        $('#Credito1').show();
    }
    else {

        $('#Credito1').hide();
    }
});



$(document).ready(function () {
    if (fact_AlCredito.checked) {
        $('#Credito').show();
        $('#Credito1').show();
    } else {
        $('#Credito').show();
        $('#Credito1').show();
    }
});