$(document).ready(function () {
    $("#b1").click(function (event) {
    /* SI ALGUNO DE LOS CAMPOS ESTÁ VACÍO NO SE REALIZA LA PETICIÓN A LA
   BASE DE DATOS */
    if ($("#usuario").val().trim().length === 0 || $("#clave").val().trim().length === 0) {
    $("#resultado").html("Indique Usuario y Clave.");
    }
    else {
    $.ajax({
    type: "POST",
    url: "control-acceso.php",
    data: {usuario: $("#usuario").val(), clave: $("#clave").val()}
    }).done(function (msg) {
    if (msg == 1) {
    /* ACCESO ACEPTADO.
    * SE REDIRIGE A acceso-aceptado.php
    * SIN DESTRUIR LAS VARIABLES DE SESIÓN */
    window.location.href = "acceso-aceptado.php";
    }
    else if (msg == 0) {
    /* ACCESO DENEGADO */
    $("#resultado").html("Usuario y/o clave incorrectos.")
    }
    });
    }
    $("#usuario").val("");
    $("#clave").val("");
 });
});
