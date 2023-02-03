using System.Collections;

// 1- Crear un programa, que recorra con un bucle for 
// del 1 al 1000, insertando en cada iteración el valor 
// del numero en un ArrayList. una vez acabe el proceso , 
// recorreremos ese ArrayList mostrando en consola la suma 
// de los números  , ejemplo: 1, 3, 6, 10.

ArrayList fibonacci = new ArrayList();

for (int i = 0; i < 1000; i++)
{
    fibonacci.Insert(i, i);
}


foreach (var item in fibonacci)
{
    var itemIndex = fibonacci.IndexOf(item);
    var suma = 0;
    for (int i = 0; i < itemIndex; i++)
    {
        suma += Convert.ToInt32(fibonacci[i]);
    }
    Console.WriteLine(suma);
}