<?php
/* INICIO DE SESIÓN, AUNQUE YA ESTÉ INICIADA, PARA
* DESTRUIRLA AL CERRAR LA SESIÓN DESDE acceso-aceptado.php
*/
if (session_status() == PHP_SESSION_NONE) {session_start();}
/* DESTRUCCIÓN DE LA SESIÓN */
session_destroy();
?>
<!DOCTYPE html>
<html>
<head>
 <meta charset="UTF-8">
 <title>Autenticación Mononivel</title>
 </head>
 <body>
 <form id="f1">
 <div id="resultado">&nbsp;</div>
 <div>
 <input type="text" name="usuario" id="usuario" placeholder="Usuario"><br>
 <input type="password" name="clave" id="clave" placeholder="Clave">
 </div>
 <div>
 <input type="button" value="Iniciar Sesión" id="b1"><br>
 Datos de Acceso<br>
 Usuario: usu1<br>
 Clave: con1
 </div>
 </form>
 <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
 <script src="js/funciones.js" type="text/javascript"></script>
 </body>
</html>