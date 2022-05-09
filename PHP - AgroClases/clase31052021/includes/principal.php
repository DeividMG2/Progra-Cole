<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Leer COOKIE</title>
</head>
<body>

<?php
//imprimir la informacion del usuario mediante una cookie
    if(isset($_COOKIE["pru"])){
        echo $_COOKIE["pru"];
    }else{
        echo ("La cookie no se ha creado");
    }


?>
</body>
</html>
