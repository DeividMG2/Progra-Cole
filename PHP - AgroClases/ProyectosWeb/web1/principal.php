<?php
$usuarioActual = $_COOKIE['usuarioActual'];
$usuario = explode("-",$usuarioActual);
var_dump($usuario);
if ($usuario[3] == "usuario") {
    header("location:index.php");
}else if($usuario[3] == "administrador"){
    header("location:includes/mantenimiento.php");
}


?>
