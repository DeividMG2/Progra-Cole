<?php

$num = 5;

if ($num==1) {
    echo ("LUNES");
}
elseif($num==2) {
    echo ("MARTES");
}
elseif ($num==3) {
    echo ("MIERCOLES");
}
elseif ($num==4) {
    echo ("JUEVES");
}
elseif ($num==5) {
    echo ("VIERNES");
}
elseif ($num==6) {
    echo ("SABADO");
}
elseif ($num==7) {
    echo ("DOMINGO");
}

echo("<br>");

switch ($num) {
    case '1':
        echo ("LUNES");
        break;
    case '2':
        echo ("MARTES");
        break;
    case '3':
        echo ("MIERCOLES");
        break;
    case '4':
        echo ("JUEVES");
        break;
    case '5':
        echo ("VIERNES");
        break;
    case '6':
        echo ("SABADO");
        break;
    case '7':
        echo ("DOMINGO");
        break;
}

?>