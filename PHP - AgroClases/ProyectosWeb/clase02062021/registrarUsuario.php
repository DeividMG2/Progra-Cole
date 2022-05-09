<style>
*{
    color: white;
}
body{
    background-color: black;
    padding-top:100px;
}
input,select,button,option{
    color:black;
}
    .contenedor{        
        margin:auto;
        text-align:center;
        width:40%;
        background-color:#222;
    }
</style>

<?php
include 'includes/conexion.php';
$conn->query("SET NAMES 'utf8'");
$idUsuario = $_REQUEST['idUsuario'];
$nombreCompleto = "";
$usuario = "";
$password = "";
$tipoUsuario = "";
$valueBtn = "registrar";
$buttonName = "Registrar";
if($idUsuario != 0)
{    	    
	$query="call buscarUsuarioXid(".$idUsuario.")";
	$result = $conn->query($query);
	if ($result->num_rows>0) {
	    $row = $result->fetch_array();
        $nombreCompleto = $row[0];
        $usuario = $row[1];
        $password = $row[2];
        $tipoUsuario = $row[3];  
        $valueBtn = "update";
        $buttonName = "Modificar";
        
    }
     
}

    

?>
<form class="contenedor" id = "formulario" name = "formulario" action="includes/operacionesDB.php" method="POST">
       
       <h1>Registro de Usuarios</h1>
      
       <BR>
       <label for="">Nombre Completo</label>
       <BR>
       <input type="text" name = "nombreCompleto" id="nombreCompleto"value="<?php echo $nombreCompleto;?>">
       <BR>
       <label for="">USUARIO</label>
       <BR>
       <input type="text" name = "usuario" id="usuario"value="<?php echo $usuario;?>">
       <BR>
       <label for="">CONTRASEÑA</label>
       <BR>
       <input type="text" name = "password" id="password"value="<?php echo $password;?>">
       <BR>
       <label for="">TIPO USUARIO</label>
       <BR>
       <select name="tipoUsuario" id="tipoUsuario">
           <?php 

                switch($tipoUsuario)
                {
                    case "administrador":
                        echo '<option value="administrador" selected="selected">administrador</option>
                        <option value="Usuario">Usuario</option>';                
                        break;
                    case "Usuario":
                        echo '<option value="administrador">administrador</option>
                        <option value="usuario" selected="selected">Usuario</option>';                
                        break;    
                    default:
                        echo '<option value="administrador">administrador</option>
                        <option value="usuario">Usuario</option>'; 
                }
           ?>           
       </select>
       <BR>
       <BR>
       <button name = "operacion" value="<?php echo $valueBtn; ?>"><?php echo $buttonName; ?></button>
       <BR>              
       <BR>        
   </form>

