<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <script src="https://kit.fontawesome.com/161df01c61.js" crossorigin="anonymous"></script>
    <link rel="stylesheet" href="css/ver-articulos.css">
    <title>Ver Articulos</title>
</head>
<?php
    $res = "1";
    $url = "";
        function cambiar_slide($num){
            
        $res = $GLOBALS["res"];
        if($res == "1"){
            $res = "#1";
        }

        if (intval($res[1]) >= 0){
            $url = "";
            if($num == 1){
                $res = intval($res[1])+1;
            }
            elseif($num == 0){
                $res = intval($res[1])-1;
            }
            
            
            
        }else{
            $res =  intval($res[1])+1;
            echo ("No puedes retroceder más");
        }  
        $url = "#$res";
        return $url;
    }

    
    ?>
<body>

    <div class="c1">

        <h1 class="title">Información <br> del Artículo</h1>
        <ul class="slider">
            
           
            <li id="1">
            <div class="imagen">
                <img class="img" src="images/fondo.jpg" alt="Articulo">
            </div>
            </li>
            <li id="2">
            <div class="imagen">
                <img class="img" src="images/1763152622f2018947b870e73e5f00e3.png" alt="Articulo">
            </div>
            </li>
            <li id="3">
            <div class="imagen">
                <img class="img" src="images/580b585b2edbce24c47b2425.png" alt="Articulo">
            </div>
            </li>
            <li id="4">
            <div class="imagen">
                <img class="img" src="images/05240-1-600x450.png" alt="Articulo">
            </div>
            </li>
            <div class="ico1">
                <?php 
                    $res = (cambiar_slide(0));                
                ?>        
                <a href=<?php echo $res;?>><i class="fas fa-chevron-left icono"></i></a>
            </div>
            <div class="ico2">
                <?php 
                    $res = (cambiar_slide(1));                
                ?>
                <a href=<?php echo $res;?>><i class="fas fa-chevron-right icono"></i></a>      
            </div>
            
        </ul>

    </div>
    <!-- <div class="container">
        <ul class="slider">
            <li id="slide1">
                <img src="images\580b585b2edbce24c47b2425.png" alt="">
            </li>
            <li id="slide2">
                <img src="images/05240-1-600x450.png" alt="">
            </li>
        </ul>

        <ul class="menu">
            <li>
                <a href="#slide1">1</a>
            </li>
            <li>
                <a href="#slide2">2</a>
            </li>
        </ul>
    </div> -->


    
</body>
</html>