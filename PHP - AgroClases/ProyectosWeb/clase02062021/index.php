<html>

<head></head>
<style>
body{
    padding-top: 100px;
}

.formulario{
    padding-top:50px;
    padding-bottom:50px;
    margin:auto;
    text-align:center;
    width:20%;
    background-color:#E0F8E6;
}
</style>
<body>
    <form class="formulario" action="includes/operacionesDB.php" method="POST">
        <label for="">USUARIO</label><BR>
        <input type="text" name = "usuario">
        <BR><LAbel>CONTRASEÑA</LAbel><BR>
        <input type="password" name = "password">
        <BR><BR>
        <BUTton name="operacion" value = "login">INGRESAR</BUTton>
        <BR>
    </form>  
</body>
</html>
