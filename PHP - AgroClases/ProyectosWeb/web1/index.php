<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="css/menu.css">
    <script src="https://kit.fontawesome.com/161df01c61.js" crossorigin="anonymous"></script>
    <title>Minstore</title>
    <link rel="apple-touch-icon" sizes="57x57" href="favicon2/apple-icon-57x57.png">
    <link rel="apple-touch-icon" sizes="60x60" href="favicon2/apple-icon-60x60.png">
    <link rel="apple-touch-icon" sizes="72x72" href="favicon2/apple-icon-72x72.png">
    <link rel="apple-touch-icon" sizes="76x76" href="favicon2/apple-icon-76x76.png">
    <link rel="apple-touch-icon" sizes="114x114" href="favicon2/apple-icon-114x114.png">
    <link rel="apple-touch-icon" sizes="120x120" href="favicon2/apple-icon-120x120.png">
    <link rel="apple-touch-icon" sizes="144x144" href="favicon2/apple-icon-144x144.png">
    <link rel="apple-touch-icon" sizes="152x152" href="favicon2/apple-icon-152x152.png">
    <link rel="apple-touch-icon" sizes="180x180" href="favicon2/apple-icon-180x180.png">
    <link rel="icon" type="image/png" sizes="192x192" href="/android-icon-192x192.png">
    <link rel="icon" type="image/png" sizes="32x32" href="favicon2/favicon-32x32.png">
    <link rel="icon" type="image/png" sizes="96x96" href="favicon2/favicon-96x96.png">
    <link rel="icon" type="image/png" sizes="16x16" href="favicon2/favicon-16x16.png">
    <link rel="manifest" href="/manifest.json">
    <meta name="msapplication-TileColor" content="#ffffff">
    <meta name="msapplication-TileImage" content="/ms-icon-144x144.png">
    <meta name="theme-color" content="#ffffff">
</head>
<?php
    $num = 2;
?>
<body>

    <div class="principal">

        <header class="header" id="1">
            <h1 class="title">Minstore</h1>
            <nav class="menu" id="menu">
                
                <div class="item-nav">
                    <a class="a-nav" href="#1"><i class="fas fa-house-user icono"></i>&nbsp;&nbsp;INICIO&nbsp;</a>
                </div>
                <div class="item-nav">
                    <a class="a-nav" href="#"><i class="fas fa-user icono"></i>&nbsp;&nbsp;MI CUENTA&nbsp;</a> 
                </div>
                <div class="item-nav">
                    <a class="a-nav" href="#"><i class="fas fa-tools icono"></i>&nbsp;&nbsp;SERVICIOS</a></div>
                <div class="item-nav">
                    <a class="a-nav" href="#3"><i class="fas fa-users icono"></i>&nbsp;&nbsp;SOBRE NOSOTROS&nbsp;</a></div>
                <div class="item-nav">
                     <a class="a-nav" href="#10"><i class="fas fa-envelope-square icono"></i>&nbsp;&nbsp;CONTÁCTENOS&nbsp;</a>
                </div>

                
                
                
               

            </nav>
        </header>
        <nav class="izq">

            <h2 class="titulo-srv">Cuenta:</h2>
            <div>
                <ul class="item-srv">
                    <li><a class="item-srv" href="includes/login.php">Iniciar Sesión</a></li>
                    <li><a class="item-srv" href="registro.php">Registrarse</a></li>
                    <li><a class="item-srv" href="includes/login.php">Cerrar Sesión</a></li>
                </ul>
            </div>

            <h2 class="titulo-srv">Productos:</h2>
            <div>
                <ul class="item-srv">
                    <li><a class="item-srv" href="#">Accesorios</a></li>
                    <li><a class="item-srv" href="#">Ropa deportiva</a></li>
                    <li><a class="item-srv" href="#">Ropa para mujer</a></li>
                    <li><a class="item-srv" href="#">Ropa para hombre</a></li>

                </ul>
            </div>

            <h2 class="titulo-srv">Servicios:</h2>
            <div>
                <ul class="item-srv">
                    <li><a class="item-srv" href="#">Entregas garantizadas</a></li>
                    <li><a class="item-srv" href="#">Pagos Seguros</a></li>
                    <li><a class="item-srv" href="#">Servicio al cliente</a></li>


                </ul>
            </div>
        </nav>

        <main class="main">
            <h3>Cuerpo de Pagina</h3>

            <!-- <div class="selec_categorias">
                <form action="includes/operaciones.php" method="POST">

                    <label> Selecciona la Categoría </label>
                    <select name="" id="">
                        <option value="">Ropa Hombre</option>
                        <option value="">Ropa Mujer</option>
                        <option href="#10" value="">Ropa Deportiva</option>
                        <option value="">Accesorios</option>
                    </select>
                
            </div>

            <div class="flecha-izquierda">
                <button name="operacion" value="previo"><img class="btnLados" src="images/izquierda.png" alt=""></button>
            </div>

            <div class="container">
            <ul class="slider">
                <li id="slide1">
                    <img src="images/hombre/c1.png" alt="">
                </li>
                <li id="slide2">
                    <img src="images/hombre/c2.png" alt="">
                </li>
                <li id="slide3">
                    <img src="images/hombre/c3.png" alt="">
                </li>
                <li id="slide4">
                    <img src="images/hombre/c4.png" alt="">
                </li>
            </ul>

        </div> -->
            <!-- <div class="flecha-derecha">
                <button name="operacion" value="next"><img class="btnLados" src="images/derecha.png" alt=""></button>
            </div>
            </form> -->
        </main>

        <!-- <footer class="footer">
            <div id="10" class="d_contacto">
                <h2 class="title-2">Contáctenos</h2>
                <form>
                    <input type="text" placeholder="Nombre y Apellidos" class="input_n">
                    <br>
                    <input type="text" placeholder="Correo" class="input_n">
                    <br>
                    <textarea class="sms" placeholder="Mensaje" cols="30" rows="10"></textarea>
                    <br>
                    <button class="btn-enviar">Enviar</button>
                </form>

            </div>
            <div class="btn-footer">
                <a class="footer-a" href="#1">Ir a Inicio<a>
            </div>
            <div class="about-us">
                <h2 id="3">Sobre Nosotros</h2>
                <p style="font-size: 20px;">Somos una empresa dedicada a la venta online de productos tanto como para hombres y mujeres donde podrás conseguir un número muy alto de artículos a unos precios muy bajos.</p>
            </div>
        </footer> -->

    </div>

</body>

</html>