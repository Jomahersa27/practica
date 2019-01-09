<?php
/*Inicio de la sesión */
if (session_status()==PHP_SESSION_NONE) {session_start();}
$usuario = $_POST["usuario"];
$clave = $_POST["clave"];
require_once ('con1.php');
$mysqli->set_charset("utf8");
/* PROTECCIÓN FRENTE A SQL INYECTADO (FUNCIÓN mysql_real_escape_string) */
$usuario = $mysqli->real_escape_string($usuario);
$clave = $mysqli->real_escape_string($clave);
if ($resultado = $mysqli->query("SELECT usuario, clave FROM usuarios WHERE
usuario='$usuario' and clave='$clave'")) {
 /* DETERMINA EL NÚMERO DE REGISTROS QUE DEVUELVE LA CONSULTA */
 $numeroRegistros = $resultado->num_rows;
 /* LIBERA LA MATRIZ QUE ALBERGA EL CONJUNTO DE RESULTADOS */
 $resultado->free();
 /* CIERRA LA CONEXIÓN */
 $mysqli->close();
 if ($numeroRegistros) {
 /* ACCESO ACEPTADO */
 $_SESSION["autentificado"] = "si";
 /* SE DEVUELVE 1 A $.ajax (done) EN funciones.js
  * INDICANDO QUE EL ACCESO HA SIDO ACEPTADO
 */
echo 1;
} else {
/* ACCESO DENEGADO */
/* DESTRUCCIÓN DE LA SESIÓN */
session_destroy();
/* SE DEVUELVE 0 A $.ajax (done) EN funciones.js
* INDICANDO QUE EL ACCESO HA SIDO DENEGADO
*/
echo 0;
}
}
?>