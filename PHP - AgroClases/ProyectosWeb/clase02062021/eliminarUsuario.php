<?php

include 'includes/conexion.php';
$conn->query("SET NAMES 'utf8'");
$idUsuario = $_REQUEST['idUsuario'];

if($idUsuario != 0)
{    	    
	$query="call eliminarUsuario(".$idUsuario.")";
	$result = $conn->query($query);
    header("location:principal.php");
}


?>