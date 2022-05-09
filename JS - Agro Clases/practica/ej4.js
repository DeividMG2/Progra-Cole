let num = prompt('Introduce un numero: ');
let suma = 0;

while(Number(num) != num)
{
        num = prompt('Introduce un numero: ');
}
suma += parseInt(num); 
while(confirm('¿Desea ingresar otro numero?'))
    {
        num = prompt('Introduce un numero: ');
        while(Number(num) != num)
        {
            num = prompt('Introduce un numero: ');
        }
        suma += parseInt(num);
    }

document.write(`El resultado de la suma es ${suma}`);

    