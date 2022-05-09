let nota = prompt('Ingrese su calificación');

if(nota != null)
{
    while(nota < 0 || nota > 10){
        alert('Su calificación debe ser mayor a 0 y menor a 10.\n Intentelo de nuevo');
        nota = prompt('Ingrese su calificación');
   }
   
   if(nota >= 0 && nota < 3)
   {
       alert('MUY DEFICIENTE');
   }
   else if(nota >= 3 && nota < 5)
   {
       alert('INSUFICIENTE');
   }
   else if(nota >= 5 && nota < 6)
   {
       alert('SUFICIENTE');
   }
   else if(nota >= 6 && nota < 7)
   {
       alert('BIEN');
   }
   else if(nota >= 7 && nota < 9)
   {
       alert('NOTABLE');
   }
   else if(nota >= 9 && nota < 11)
   {
       alert('SOBRESALIENTE');
   }
}
