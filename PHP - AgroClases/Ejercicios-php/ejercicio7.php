<?php

$n1 = 1;
$n2 = 1;

    echo("Tabla del 1");
    echo ("<br>"); 
    echo ("<br>"); 
    while ($n1 <= 10)
    {
        echo ($n1*$n2);
        echo ("<br>");
        if($n2 == 10 and $n1<=10)
        {
            $n2 = 1;
            $n1 ++;
            if ($n1 <= 10) {
                echo ("<br>"); 
                echo("Tabla del $n1");
                echo ("<br>"); 
                echo ("<br>");
            }
             
        }else{
            $n2++;
        }
    }


    for ($i=1; $i <= 10; $i++) { 
        echo ("<br>"); 
                echo("Tabla del $i");
                echo ("<br>"); 
                echo ("<br>");
        for ($j=1; $j <= 10; $j++) { 
            echo ($i * $j);
            echo ("<br>");
        }
    }
?>