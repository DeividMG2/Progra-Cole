<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<!--

        Que son?
            - Guardan informacion de ficheros de texto y se almacenan en el disco duro (contraseñas, fechas, direcciones y muchas otras cosas).
            - Normalmente se guarda informacion necesaria para que el usuario no tenga que ingresar el usuario y contraseña cada vez que entra.

        Como crear una cookie?

                setcookie("prueba","Esta es la info de mi primer cookie");

        
        Acceder a los datos almacenados en una cookie

-->
<body>
    
    <?php

        setcookie("prueba","Esta es la info de mi primer cookie", time()+604800);
    ?>

</body>
</html>