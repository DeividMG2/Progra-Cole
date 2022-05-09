<?php
ini_set('display_errors', 1);
error_reporting(0);
//header('Content-type: application/json');
//ejecutar lo que está en el archivo de conexion.php para hacer la conexion con la base de datos
include 'conexion.php';

$tipo = $_POST['operacion'];
echo ($tipo);

if ($_POST['operacion'] == 'login') {
	$usuario = $_POST['usuario'];
	$password = $_POST['password'];

	$query = "call login('" . $usuario . "');";
	//echo $query;
	//ejecuto la consulta
	$result = $conn->query($query);
	$valores = mysqli_fetch_array($result);
	echo $query;
	//num_rows tiene la cantidad de filas que se devuelve en la consulta
	if(password_verify($password, $valores['Password'])){
		echo "Entre al primer if  <br>";
		if ($result->num_rows > 0) {
			echo "Entre al segundo if <br>";
			var_dump($valores);
			$usuarioEncontrado = $valores['Id'] . "-" . $valores['Nombre Completo'] . "-" . "-" . $valores['Tipo'] . "-" . $valores['Usuario'] . "-" . $valores['Password'];
			setcookie("usuarioActual", $usuarioEncontrado, (time() + 3600), "/");
			if ($valores["Tipo"] == "usuario") {
				header("location:../index.php");
			} else if ($valores["Tipo"] == "administrador") {
				header("location:mantenimiento.php");
			}
		} else {
			header("location:login.php");
		}
	}else{
		header("location:login.php");	}
	
} else if ($_POST['operacion'] == 'registrar') {

	$pass = $_REQUEST['password'];
	$new_pass = password_hash($pass, PASSWORD_DEFAULT, ['cost' => 10]);
	if($_POST['nombreCompleto'] != "" && $_REQUEST['usuario'] != "" && $pass != "" && $_REQUEST['tipoUsuario'] != "")
	{
		if (password_verify($pass, $new_pass)) {
			$sql = "call registrarUsuario('" . $_POST['nombreCompleto'] . "','" . $_REQUEST['usuario'] . "','" . $new_pass . "','" . $_REQUEST['tipoUsuario'] . "')";
			$conn->query($sql) or die($conn->error . __LINE__);
			$query = "call login('" . $_REQUEST['usuario'] . "','" . $_REQUEST['password'] . "');";
			$result = $conn->query($query);
			$valores = mysqli_fetch_array($result);
			$usuarioEncontrado = $valores['Id'] . "-" . $valores['Nombre Completo'] . "-" . "-" . $valores['Tipo'] . "-" . $valores['Usuario'] . "-" . $valores['Password'];
			setcookie("usuarioActual", $usuarioEncontrado, (time() + 3600), "/");
			header("location:../index.php");
	}

	}
} else if ($_POST['operacion'] == 'update') {
	$idUsuario = $_REQUEST['idUsuario'];
	$pass = $_POST['password'];
	$new_pass = password_hash($pass, PASSWORD_DEFAULT, ['cost' => 10]);
	// echo ("<br> ID: " . $idUsuario);
	if ($idUsuario != 0) {
		$result = $conn->query($query);
		$query = "call modificarUsuario('" . $_POST['nombreCompleto'] . "','" . $_POST['usuario'] . "','" . $_POST['tipoUsuario'] . "','" . $new_pass . "'," . $_POST['idUsuario'] . ")";
		$result = $conn->query($query);
		header("location:mantenimiento.php");
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
