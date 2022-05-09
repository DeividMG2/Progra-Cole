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
        $arreglo = ['JUAN-ROBLES-25-AGUAS ZARCAS-88786543-juanrobles@gmail.com', 
        'RIGOBERTO-PEREZ-34-CIUDAD QUESADA-85478586-rigop@gmail.com',
        'OSCAR-ROJAS-20-FLORENCIA-88674874-oscarr@hotmail.com',
        'LUIS-ARROYO-26-SANTA CLARA-88888888-luisar@outlook.com'];

//CONTINUE CON SU SOLUCIÓN AQUÍ
//PISTA: UTILIZAR COMANDO O FUNCIÓN DE PHP EXPLODE

        $arreglo2 = [];
        $var = explode("-",$arreglo[0]);
        array_push($arreglo2, $var);
        for ($i=1; $i < 4; $i++) { 
            $var2 = explode("-",$arreglo[$i]);
            array_push($arreglo2, $var2);
        }
        echo 
        (
            "<thead>
                <th>Nombre</th>
                <th>Apellido</th>
                <th>Edad</th>
                <th>Direccion</th>
                <th>Telefono</th>
                <th>Email</th>
            </thead>"
        );

        for ($i=0; $i < 4; $i++) { 
            echo "<tr>";
            foreach ($arreglo2[$i] as $a) {
                echo "<td>$a</td>";
            } 
            echo "</tr>";
        }

        ?>
        
</table>

</body>
</html>