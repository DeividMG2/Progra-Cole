<?php
	ini_set('display_errors',1);
	error_reporting(0);
	//header('Content-type: application/json');
	//ejecutar lo que está en el archivo de conexion.php para hacer la conexion con la base de datos
	include 'conexion.php';	
	
	if($_POST['operacion'] == 'login')
	{
		$usuario = $_POST['usuario'];
		$password = $_POST['password'];
		
		$query = "call login('".$usuario."','".$password."');";

		//echo $query;
		//ejecuto la consulta
		$result = $conn->query($query);
		//num_rows tiene la cantidad de filas que se devuelve en la consulta
		if($result->num_rows>0)
		{
			//echo $result->num_rows;
			$valores = mysqli_fetch_array($result);			
			$usuarioEncontrado = $valores['idUsuario']."-".$valores['Nombre']."-".$valores['Usuario']."-".$valores['Password']."-".$valores['TipoUsuario'];       					            
			setcookie("usuarioActual", $usuarioEncontrado, (time()+3600), "/");       
			header("location:../principal");
		}
		else
		{
			header("location:../index.php");
		}	
	}	
?>