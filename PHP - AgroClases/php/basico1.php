<?php

// ****************** HOLA MUNDO ********************
// Así se imprime.
print "Hola mundo p";
echo "<br>";
echo"Hola Mundo";


// ****************** VARIABLES ********************
// Asi se cren las variables:
$numero = 123432;
echo($numero);

var_dump(1<2);

// Esto hace una comparacion que sea igual Y QUE SEA DEL MISMO TIPO
var_dump("1" === 1);

// Esto imprirá un -1 si el de la izquierda es menor
// Un 0 si son iguales 
// Y un 1 si el de la izquiera es mayor
var_dump(7 <=> 3);

// Esto verifica si es string
var_dump(is_string("Hola"));


// ****************** ARREGLOS ********************
// Asi se crea el arreglo
$arreglo = ["1",2,76,true];
var_dump($arreglo);

// Acceder a un elemento del array
echo $arreglo[1];

// Añade un elemento en el indice del arreglo
$arreglo[2] = "Nuevo Producto";
var_dump($arreglo);

// Añadir un elemento nuevo al final del array
array_push($arreglo, "Ultimo Articulo");
var_dump($arreglo);

// Añadir un elemento nuevo al inicio del array
array_unshift($arreglo, "Primer Articulo");
var_dump($arreglo);

// Para ver el contenido de un array
echo "<pre>";
var_dump($arreglo);
echo "</pre>";


// ****************** CONDICIONALES ********************

$premium = false;
if($premium){
    echo "Puedes pasar";
}
else{
    echo "No Puedes Pasar";
}
echo("<br>");

// ****************** CONDICIONALES ********************
function sumar($n1 = 0, $n2 = 2){   
    echo $n1 + $n2;
}
sumar();
echo("<br>");
sumar(10);
echo("<br>");
sumar(10,1);
echo("<br>");

?>