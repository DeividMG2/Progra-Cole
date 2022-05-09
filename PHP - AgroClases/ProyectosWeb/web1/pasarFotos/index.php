<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="css/styles.css">
    <title>Sliders</title>
</head>
<?php
$num = 1;
?>
<body>
    <div class="container">
        <ul class="slider">
            <li id="slide1">
                <img src="../images/hombre/c1.png" alt="">
            </li>
            <li id="slide2">
                <img src="../images/hombre/c2.png" alt="">
            </li>
            <li id="slide3">
                <img src="../images/hombre/c3.png" alt="">
            </li>
            <li id="slide4">
                <img src="../images/hombre/c4.png" alt="">
            </li>
        </ul>


        <form action="includes/operaciones.php" method="POST">
        <ul class="menu">
            <li>
                <button name="operacion" value="next" class="btn1">Next</button>
            </li>
            <li>
                <button name="operacion" value="previo" class="btn1">Previo</button>
            </li>

        </ul>
        </form>
    </div>
</body>

</html>