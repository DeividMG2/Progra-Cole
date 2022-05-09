<?php

$num = 1;
$opcion = $_POST['operacion'];


if (isset($_COOKIE['num'])) {
    $numActual = intval($_COOKIE['num']);
    if ($numActual >= 1 and $numActual < 4 and $opcion == 'next') {
        $num = $numActual+1;
        header('location: ../index.php#slide'.$num);
        setcookie("num", $num, (time() + 3600));
    }else if($numActual > 1 and $numActual <= 4 and $opcion == 'previo'){
        $num = $numActual-1;
        header('location: ../index.php#slide'.$num);
        setcookie("num", $num, (time() + 3600));
    }
    if ($numActual == 1 and $opcion == 'previo') {
        $num = 4;
        header('location: ../index.php#slide'.$num);
        setcookie("num", $num, (time() + 3600));    }
   
}

if ($opcion == 'next') {
    header('location: ../index.php#slide'.($num));
    setcookie("num", $num, (time() + 3600));

}
else if ($opcion == 'previo') {
    header('location: ../index.php#slide'.($num));
    setcookie("num", $num, (time() + 3600));

}

?>








