<?php
$usuarioActual = $_COOKIE['usuarioActual'];
$usuario = explode("-",$usuarioActual);
var_dump($usuario);
echo "Nombre Completo: ".$usuario[1];
echo "<br>";
echo "Usuario: ".$usuario[2];
echo "<br>";
echo "Tipo Usuario: ".$usuario[4];
?>
