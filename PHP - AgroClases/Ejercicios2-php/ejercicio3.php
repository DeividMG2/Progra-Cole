<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="styles.css">
    <title>Ejercicio 2</title>
</head>
<body>
    <table>
    
    <?php

$productos = [
    [
        'codigo' => 1,
        'nombre' => 'Tablet', 
        'precio' => 200,
        'disponible' => 'Disponible'
    ],
    [
        'codigo' => 2,
        'nombre' => 'Television 24"', 
        'precio' => 300,
        'disponible' => 'Disponible'
    ],
    [
        'codigo' => 3,
        'nombre' => 'Monitor Curvo', 
        'precio' => 400,
        'disponible' => 'No Disponible'
    ]
];

//CONTINUE CON SU SOLUCIÓN AQUÍ
    echo '<link href="styles.css" type="text/css" rel="stylesheet">';
    echo    
        (
            "<thead>
                <th>Codigo</th>
                <th>Nombre</th>
                <th>Precio</th>
                <th>Disponible</th>
                <th>Editar</th>
                <th>Eliminar</th>
            </thead>"
        );
    $ruta_ed = "img/edit.png";
    $ruta_el = "img/delete.png";

    foreach ($productos as $key => $value) {
        echo "<tr>";
        foreach ($value as $v) {
            echo"<td>$v</td>";
        }
        echo("<td><button><img class='imagen-2' src=$ruta_ed></button></td>");
        echo("<td><button><img class='imagen' src=$ruta_el></button></td>");
        echo "</tr>";
    }

    

?>

    </table>
</body>
</html>