using System.Collections;

// FIFO (first in fisrt out)

Queue cola = new Queue();


// Añadir elementos al final de la cola.
cola.Enqueue(3);
cola.Enqueue(12);
cola.Enqueue(2);
cola.Enqueue(21);

// Extraer valores del principio de la cola
var valorCola  = cola.Dequeue();
Console.WriteLine(valorCola);

// Para observar el valor sin quitarlo de la cola
var valor = cola.Peek();
Console.WriteLine(valor);

// Comprobar si existe un valor
if (cola.Contains(5)) {
    Console.Write("Contiene 5");
}

// Lee los items del primero al ultimo 
foreach (var item in cola) {
    Console.WriteLine(item);
}

var contador = cola.Count;