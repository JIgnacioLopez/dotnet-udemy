// 2-  Pedir por pantalla 5 nombres, e insertarlo en una 
// Lista (List) una vez insertados, se pedirá que 
// introduzcamos un nombre, el programa tendrá que decirnos, 
// si ese nombre esta contenido en la lista.

List<string> listaNombres = new List<string>();

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Ingrese un nombre");
    var nombre = Console.ReadLine();
    listaNombres.Insert(i,nombre);
}

Console.WriteLine("Ingrese el nombre a comparar");
var nuevoNombre = Console.ReadLine();
var enLista = false;
foreach(var item in listaNombres) {
    if(nuevoNombre == item) {
        enLista = true;
    }
}
if (enLista) {
    Console.WriteLine("El nombre ya se encuentra en la lista");
} else {
    Console.WriteLine("El nombre no se encuentra en la lista");
}
