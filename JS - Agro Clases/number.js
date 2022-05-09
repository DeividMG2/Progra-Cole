//funcion number nos devuelve un valor en numero, siempre y cuando este como caracter 
//o cadena sea un numero
let num = Number("5");
console.log(num);

//observe el siguiente ejemplo donde el valor que recibe por parámetro la función Number no
//es un número
num = Number("5"); //intente cambiar el 5 por letras o por ejemplo colocar 5a en lugar de "5"
console.log(num);
//nos devuelve NaN
//¿Qué quiere decir NaN en javascript?
//Not-A-Number: No es Un Número

//observe el siguiente ejemplo
if(Number(num) == num)
{
    console.log("Es un número");
}else 
    console.log("No es un número");

    //que sucede si viene un número válido en la variable num?
    //que sucede si no viene un número válido en la variable num?
    //probarlo para determinar su resultado