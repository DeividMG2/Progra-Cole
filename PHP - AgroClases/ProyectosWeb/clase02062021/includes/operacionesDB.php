<style>

form {
	display:none;
} 

</style>

<?php
	ini_set('display_errors',1);
	error_reporting(0);
	//header('Content-type: application/json');
	//ejecutar lo que está en el archivo de conexion.php para hacer la conexion con la base de datos
	include 'conexion.php';
	include '../registrarUsuario.php';

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
			$usuarioEncontrado = $valores['Id']."-".$valores['Usuario']."-".$valores['Password']."-".$valores['Tipo'];       					
            setcookie("usuarioActual", $usuarioEncontrado, (time()+3600), "/");       
			header("location:../principal.php");
		}
		else
		{
			header("location:../index.php");
		}	
	}
	else if($_POST['operacion'] == 'registrar')
	{
		$sql = "call registrarUsuario('".$_POST['nombreCompleto']."','".$_REQUEST['usuario']."','".$_REQUEST['password']."','".$_REQUEST['tipoUsuario']."')";
		$conn->query($sql) or die($conn->error.__LINE__);
		header("location:../principal.php");
	}else if ($_POST['operacion'] == 'update'){
	
			 $sql = "call modificarUsuario('".$nombreCompleto."','".$usuario."','".$password."','".$tipoUsuario."',".$idUsuario.")";
			 $result = $conn->query($query);
			 if ($idUsuario != null){
				 echo "Modificado correctamente";
			 }else{
				 echo "Error al modificar";
			 }
	
	
	}


	function buscarUsuariosRegistrados()
	{		 
		$query = "call verUsuarios()";
		//echo $query;
		include 'conexion.php';	
		$result = $conn->query($query);
		return $result;		 
	}

 
?>