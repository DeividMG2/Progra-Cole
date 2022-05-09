//UNIR DOS OBJETOS CON SPREAD OPERATOR

const producto = {
    nombreProducto:  "Monitor 20 Pulgadas", 
    precio: 3000,
    disponible: true
}


const datos = {
    medida: '2m',
    peso: '1km'
}

//UNIR DOS OBJETOS EN LA VARIABLE nuevoProducto
const nuevoProducto = {...producto,...datos}
console.log(producto);
console.log(nuevoProducto);