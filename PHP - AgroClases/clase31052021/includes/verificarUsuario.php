<?php




$usuarios = [

    [

        'codigo' => 1,

        'nombre' => 'admin', 

        'password' => 'x1y1',

        'tipo' => 'administrador'

    ],

    [

        'codigo' => 2,        

        'nombre' => 'col1', 

        'password' => 'c1c1',

        'tipo' => 'colaborador1'

    ],

    [

        'codigo' => 3,      

        'nombre' => 'col2', 

        'password' => 'c2c2',

        'tipo' => 'colaborador2'

    ]]; 

    $name = $_POST['nombre'];
    $contraseña = $_POST['password'];
    $error = false;

    foreach ($usuarios as $sub) {
        if ($sub['nombre'] == $name and $sub['password'] == $contraseña) {
            $cod = $sub['codigo'];
            $tipo = $sub['tipo'];
            setcookie("pru","Codigo: $cod <br> Nombre: $name <br> Contraseña: $contraseña <br> Tipo: $tipo", time()+500);
            header("Location:principal.php");
        }else{
            $error = $GLOBALS['error'];
            $error = true;
        }
        
    }    
    if ($error) {
        echo "<h1>USUARIO O CONTRASEÑA INCORRECTA</h1>";

    }

?>