<!DOCTYPE html>
<html lang="es">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="../css/mante.css">
    <title>Mantenimiento</title>
</head>

<body>

    <?php

    include 'conexion.php';
    $usuarioActual = $_COOKIE['usuarioActual'];
    $usuarioAc = explode("-", $usuarioActual);
    $conn->query("SET NAMES 'utf8'");
    $nombreCompleto = "";
    $usuario = "";
    $password = "";
    $tipoUsuario = "";
    $valueBtn = "registrar";
    $buttonName = "Registrar";
    $idUsuario = $usuarioAc[0];

    ?>

    <header>
        <h1>Mantenimiento</h1>
        <nav>
            <?php

            if ($usuarioAc[3] == "administrador") {
                echo '
                <a class="a-nav" href="../index.php">Ver Página</a>
                <a class="a-nav" onclick="mostrarFormularioRegistro()" href="../registro.php">Registrar Usuario</a>
                <a class="a-nav" onclick="verUsuariosRegistrados()" href="#">Mostrar Usuarios</a>
                <a class="a-nav" onclick="ocultarFormulario()" href="#">Ocultar Usuarios</a> 
                <a class="a-nav" onclick="salir()" href="#">Salir</a>';
            } else if ($usuarioAc[3] == "Usuario") {
                echo '
                <a class="a-nav" onclick="salir()" href="#">Salir</a>';
            }
            ?>
        </nav>
    </header>
    <div class="main">
        <div id="usuariosRegistrados" class="tabla" style="display:none">
            <?php
            include 'operacionesDB.php';
            $result = buscarUsuariosRegistrados();
            echo "<br><table border='1'>";
            echo "<tr><td>idUsuario</td><td>Nombre</td><td>Usuario</td><td>TipoUsuario</td><td>Editar</td><td>Eliminar</td></tr>";
            while ($usuarioAc = mysqli_fetch_array($result)) {
                echo "<tr>";
                echo "<td>" . $usuarioAc[0] . "</td>";
                echo "<td>" . $usuarioAc[1] . "</td>";
                echo "<td>" . $usuarioAc[2] . "</td>";
                echo "<td>" . $usuarioAc[3] . "</td>";
                echo "<td> <img src = '../images/edit.png' value=" . $usuarioAc[0] . " style='cursor:pointer' onclick='editarUsuario(" . $usuarioAc[0] . ")'> </td>";
                echo "<td> <img src = '../images/delete.png' value=" . $usuarioAc[0] . " style='cursor:pointer' onclick='eliminarUsuario(" . $usuarioAc[0] . ")'> </td>";
                echo "</tr>";
            }
            echo "</table>";
            echo "<p>Cantidad Registros: " . $result->num_rows . "</p>";
            ?>
        </div>

        <form id="formulario" name="formulario" action="includes/operacionesDB.php" method="POST">

            <h1>Registro de Usuarios</h1>
            <label for="">CODIGO</label>
            <BR>
            <input type="text" name="codigo" id="codigo">
            <BR>
            <label for="">Nombre Completo</label>
            <BR>
            <input type="text" name="nombreCompleto" id="nombreCompleto">
            <BR>
            <label for="">USUARIO</label>
            <BR>
            <input type="text" name="usuario" id="usuario">
            <BR>
            <label for="">CONTRASEÑA</label>
            <BR>
            <input type="text" name="password" id="password">
            <BR>
            <label for="">TIPO USUARIO</label>
            <BR>
            <select name="tipoUsuario" id="tipoUsuario">
                <option value="administrador">administrador</option>
                <option value="Usuario">usuario</option>
            </select>
            <BR>
            <BR>
            <button name="operacion" value="registrar">REGISTRAR</button>
            <BR>
            <BR>

        </form>
    </div>
    <script type="text/javascript">
        function mostrarFormularioRegistro() {
            window.location = "../registro.php?idUsuario=0";
        }

        function ocultarFormulario() {
            document.getElementById('formulario').style.display = 'none';
            document.getElementById('usuariosRegistrados').style.display = 'none';
        }

        function verUsuariosRegistrados() {
            document.getElementById('formulario').style.display = 'none';
            document.getElementById('usuariosRegistrados').style.display = 'block';
        }

        function editarUsuario(idUsuario) //,usuario, password, tipoUsuario)
        {
            alert("Se editará el usuario: " + idUsuario);
            window.location = "../registro.php?idUsuario=" + idUsuario;
        }

        function eliminarUsuario(idUsuario) {
            alert("Eliminar usuario: " + idUsuario);
            window.location = "../eliminarUsuario.php?idUsuario=" + idUsuario;

        }

        function salir() {
            window.location = "login.php";
        }
    </script>
</body>
</html>