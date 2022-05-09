const numeros = [10,20,30,40,50];
console.log(numeros);
console.table(numeros);
const meses = new Array('enero','febrero','marzo','abril','mayo');
console.log(meses);
const arreglo = ["hola",10,true,"si",null,{nombre:"Juan",trabajo:"Programador"},[1,2,3]];
console.log(arreglo);
console.log(arreglo.length);

//acceder al campo 3 del arreglo llamado: arreglo
console.log(arreglo[3]);

//conocer extension de un arreglo
console.log(arreglo.length);

meses.forEach(function(mes){
    console.log(mes);
});