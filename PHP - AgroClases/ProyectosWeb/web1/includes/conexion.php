<?php
    //Conectar con la Base de Datos
    $DB_HOST = 'localhost';
    $DB_NAME = 'miproyectoweb';
    $DB_USER = 'root';
    $DB_PASS = '';
        
	$conn = new mysqli($DB_HOST, $DB_USER, $DB_PASS, $DB_NAME);
    
	if ($conn->connect_error) 
	{
	  echo $error->$conn->conect_error;
	}
  //else echo "Conexión Establecida";
	 
?>