<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="styles.css">
    <title>Ejercicio</title>
</head>
<body>
    <table>
    
    <?php

    for ($i=0; $i < 10; $i++) { 
        echo ("<tr>");
        for ($j=0; $j < 10; $j++) { 
            echo "<td>$j,$i</td>";
        }
        echo ("</tr>");
    }
    ?>

    </table>
</body>
</html>
