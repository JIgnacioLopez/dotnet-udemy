/* Stack
Es una  estructura de tipo LIFO 
(last in first out)
*/
using System.Collections;


Stack pila = new Stack();
pila.Push(1);
pila.Push(5);
pila.Push(10);
pila.Push(3);


int contador = pila.Count;
Console.WriteLine(contador);

var numero = pila.Pop();

// recorrera los elementos del ultimo al primero
foreach(var item in pila){
    Console.WriteLine(item);
}

contador = pila.Count;
Console.WriteLine(contador);

if (pila.Contains(10)) {
    Console.WriteLine("Contiene un 10");
}

// Limpia la pila
pila.Clear();

