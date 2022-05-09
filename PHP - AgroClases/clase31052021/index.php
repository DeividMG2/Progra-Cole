<html>
<head>
        <meta charset="UTF-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <link rel="stylesheet" href="css/styles.css">
        <title>Login</title>
    </head>

<body>

<div class="login">

    <h1>Inicia Sesión</h1>
    <form action="includes/verificarUsuario.php" method="POST">
    
        <div class="d1">
            <label for="">Nombre</label>
            <input type="text" name="nombre"  class="entrada">
        </div>
        <div class="d2">
            <label for="">Contraseña</label>
            <input type="password" class="entrada" name="password">
        </div>
        <button class="btn1">Aceptar</button>

    </form>

</div>

    <?php


?>
</body>
</html>