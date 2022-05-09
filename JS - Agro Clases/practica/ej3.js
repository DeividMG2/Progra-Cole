let cadena = prompt('Introduce un texto: ');
document.write("<br>"+cadena);
while(confirm("Desea Continuar"))
{
    cadena = prompt('Introduce un texto: ');
    document.write("<br>"+cadena);
}
