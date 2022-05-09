 <?php
$usuarioActual = $_COOKIE['usuarioActual'];
$usuario = explode("-",$usuarioActual);
echo "idUsuario: ".$usuario[0];
echo "<br>";
echo "Usuario: ".$usuario[1];
echo "<br>";
echo "Tipo Usuario: ".$usuario[3];

?>

<style>
.contenedor{
    background-color:#E0F8E6;
    width:40%;
    margin:auto;
    text-align:center;
}

form{
    display:none;
}

table{
    margin:auto;
    text-align:center;
}

</style>

<div class="contenedor">    
    <h2>OPCIONES DISPONIBLES</h2>   
    <?php 
        if($usuario[3]=="administrador")
        {
            echo '
            <button onclick="mostrarFormularioRegistro()">REGISTRAR USUARIO</button>  
            <button onclick="ocultarFormulario()">OTRAS</button>  
            <button onclick="verUsuariosRegistrados()">VER USUARIOS REGISTRADOS</button>
            <button onclick="salir()">SALIR</button>';
        }

        else if($usuario[3]=="Usuario")
        {
            echo '
            <button onclick="salir()">SALIR</button>';
        }
    ?>
    
    <div id="usuariosRegistrados"  style="display:none">
            <?php
                include 'includes/operacionesDB.php';
                $result = buscarUsuariosRegistrados();
                echo "<br><table border='1'>";
                echo "<tr><td>idUsuario</td><td>Nombre</td><td>Usuario</td><td>TipoUsuario</td><td>Editar</td><td>Eliminar</td></tr>";
                while ($valores = mysqli_fetch_array($result)) 
	            {
                    echo "<tr>";
                    echo "<td>".$valores[0]."</td>";
                    echo "<td>".$valores[1]."</td>";
                    echo "<td>".$valores[2]."</td>";
                    echo "<td>".$valores[3]."</td>";
                    echo "<td> <img src = 'img/edit.png' value=".$valores[0]." style='cursor:pointer' onclick='editarUsuario(".$valores[0].")'> </td>";
                    echo "<td> <img src = 'img/delete.png' value=".$valores[0]." style='cursor:pointer' onclick='eliminarUsuario(".$valores[0].")'> </td>";
                    echo "</tr>";
                }        
                echo "</table>";
                echo "<p>Cantidad Registros: ".$result->num_rows."</p>";
            ?>
    </div>
                
    <br><br>
    <form id = "formulario" name = "formulario" action="includes/operacionesDB.php" method="POST">
       
        <h1>Registro de Usuarios</h1>
        <label for="">CODIGO</label>
        <BR>
        <input type="text" name = "codigo" id="codigo">
        <BR>
        <label for="">Nombre Completo</label>
        <BR>
        <input type="text" name = "nombreCompleto" id="nombreCompleto">
        <BR>
        <label for="">USUARIO</label>
        <BR>
        <input type="text" name = "usuario" id="usuario">
        <BR>
        <label for="">CONTRASEÑA</label>
        <BR>
        <input type="text" name = "password" id="password">
        <BR>
        <label for="">TIPO USUARIO</label>
        <BR>
        <select name="tipoUsuario" id="tipoUsuario">
            <option value="administrador">administrador</option>
            <option value="Usuario">usuario</option>
        </select>
        <BR>
        <BR>
        <button name = "operacion" value="registrar">REGISTRAR</button>
        <BR>
        <BR>
         
    </form>

</div>

<script type="text/javascript" >

    function mostrarFormularioRegistro()
    {    
        window.location = "registrarUsuario.php?idUsuario=0";
    }

    function ocultarFormulario()
    {    
        document.getElementById('formulario').style.display='none';
        document.getElementById('usuariosRegistrados').style.display='none';
    }

    function verUsuariosRegistrados()
    {    
        document.getElementById('formulario').style.display='none';
        document.getElementById('usuariosRegistrados').style.display='block';
    }

    function editarUsuario(idUsuario)//,usuario, password, tipoUsuario)
    {                   
        alert("Se editará el usuario: " + idUsuario);
        window.location = "registrarUsuario.php?idUsuario="+idUsuario;
    }

    function eliminarUsuario(idUsuario)
    {    
        alert("Eliminar usuario: " + idUsuario);
        window.location = "eliminarUsuario.php?idUsuario="+idUsuario;

    }

    function salir()
    {    
        window.location = "index.php";
    }
    

</script>