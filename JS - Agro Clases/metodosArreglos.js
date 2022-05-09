const numeros = [10,20,30,40,50];

//console.table(numeros);

numeros[5] = 60;
numeros[numeros.length] = 70;
//console.table(numeros);


numeros.push(80);//agregar al final del arreglo
console.table("despues de push", numeros);
numeros.pop();//sacar el ultimo elemento del arreglo
console.table("despues de pop", numeros);
numeros.push(90,100);
console.table(numeros);

numeros.unshift(-10);//agregar al inicio
console.table(numeros);

numeros.shift();//eliminar el primer elemento del arreglo
console.table(numeros);

numeros.splice(0,2);
console.table(numeros);

const masNumeros = [...numeros, 110];
console.table(masNumeros);

