<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Ejercicio 6</title>
</head>
<?php

    $productos = [
        [
            "nombre" => "Tablet",
            "precio" => 200,
            "disponible" => true
        ],
        [
            "nombre" => "Television 24",
            "precio" => 300,
            "disponible" => true
        ],      
        [
            "nombre" => "Monitor Curvo",
            "precio" => 400,
            "disponible" => false
        ] 
    ]

?>
<body>
    <select>
            
            <?php

                foreach ($productos as $producto) {
                    echo '<option value="',$producto["nombre"],'">',$producto["nombre"],'</option>';
                }

            ?>

    </select>
</body>
</html>