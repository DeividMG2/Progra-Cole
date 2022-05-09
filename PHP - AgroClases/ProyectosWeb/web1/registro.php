<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="css/registro.css">
    <link rel="apple-touch-icon" sizes="57x57" href="/favicon3/apple-icon-57x57.png">
    <link rel="apple-touch-icon" sizes="60x60" href="/favicon3/apple-icon-60x60.png">
    <link rel="apple-touch-icon" sizes="72x72" href="/favicon3/apple-icon-72x72.png">
    <link rel="apple-touch-icon" sizes="76x76" href="/favicon3/apple-icon-76x76.png">
    <link rel="apple-touch-icon" sizes="114x114" href="/favicon3/apple-icon-114x114.png">
    <link rel="apple-touch-icon" sizes="120x120" href="/favicon3/apple-icon-120x120.png">
    <link rel="apple-touch-icon" sizes="144x144" href="/favicon3/apple-icon-144x144.png">
    <link rel="apple-touch-icon" sizes="152x152" href="/favicon3/apple-icon-152x152.png">
    <link rel="apple-touch-icon" sizes="180x180" href="/favicon3/apple-icon-180x180.png">
    <link rel="icon" type="image/png" sizes="192x192" href="/favicon3/android-icon-192x192.png">
    <link rel="icon" type="image/png" sizes="32x32" href="/favicon3/favicon-32x32.png">
    <link rel="icon" type="image/png" sizes="96x96" href="/favicon3/favicon-96x96.png">
    <link rel="icon" type="image/png" sizes="16x16" href="/favicon3/favicon-16x16.png">
    <link rel="manifest" href="/favicon3/manifest.json">
    <meta name="msapplication-TileColor" content="#ffffff">
    <meta name="msapplication-TileImage" content="/favicon3/ms-icon-144x144.png">
    <meta name="theme-color" content="#FFFFFF">
    <title>Registrarse</title>
</head>
<?php
include 'includes/conexion.php';
$conn->query("SET NAMES 'utf8'");
$valueBtn = "registrar";
$buttonName = "Registrar";
$nombreCompleto = "";
$usuario = "";
$password = "";

if (isset($_REQUEST['idUsuario'])) {
    $idUsuario = $_REQUEST['idUsuario'];
    if ($idUsuario != 0) {
        $valueBtn = "update";
        $buttonName = "Actualizar";
        $query = "call buscarUsuarioXid(".$idUsuario.")";
	    $result = $conn->query($query);
        $valores = mysqli_fetch_array($result);
        $nombreCompleto = $valores['Nombre Completo'];
        $usuario = $valores['Usuario'];
        $password = $valores['Password'];
    } 
}



?>

<body>
    <div class="main">
        <form action="includes/operacionesDB.php" method="POST">
            <h1>Registrarse</h1>
            <!-- $sql = "call registrarUsuario('".$_POST['nombreCompleto']."','".$_REQUEST['usuario']."','".$_REQUEST['password']."','".$_REQUEST['tipoUsuario']."')"; -->

            <div class="user">
                <i class="fas fa-user iconos"></i>
                <input type="text" name='nombreCompleto' value="<?php echo $nombreCompleto; ?>" placeholder="Nombre Completo" class="inp">
                <?php
                    if (isset($_REQUEST['idUsuario'])) {
                        $idUsuario = $_REQUEST['idUsuario'];
                    }else{
                        $idUsuario = 0;
                    }
                ?>
                <input style="display:none;" type="text" name="idUsuario" value="<?php echo $idUsuario; ?>">
            </div>
            <div class="user">
                <i class="fas fa-user iconos"></i>
                <input type="text" name="usuario" value="<?php echo $usuario; ?>" placeholder="Usuario" class="inp">
            </div>
            <div class="user">
                <i class="fas fa-key iconos"></i>
                <input type="password" name="password" placeholder="Contraseña" class="inp3">
            </div>
            <div class="user">
                <select name="tipoUsuario" id="tipoUsuario" class="tipoUser">
                    <option selected disabled>Tipo de Usuario</option>
                    <option value="administrador">Administrador</option>
                    <option value="usuario">Usuario</option>
                </select>
            </div>
            <div>
                <button class="button" name='operacion' value='<?php echo $valueBtn ?>'><?php echo $buttonName ?></button>
            </div>
            <div>
                <button class="button" name='operacion' value="login">Iniciar Sesion</button>
            </div>
        </form>
    </div>
</body>

</html>