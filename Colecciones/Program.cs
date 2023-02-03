            // Se recomienda Utilizar List en ves de array list
using System;
using System.Collections;

namespace colecciones {
    internal class Program {
        static void Main(string[] args){
            // ArrayList
            // Guarda objetos
            ArrayList lista = new ArrayList();
            
            lista.Add(1);
            lista.Add("juan");

            // Se puede acceder los elementos por su indice.
            var elemento = lista[0];

            // cantidad de elementos de la lista
            int contador = lista.Count;

            // Instertar un elemento en una posicion especifica en una lista
            // tener en cuenta que las listas deben ser continuas.
            lista.Insert(contador,"Pedro");

            // Remover elemento de una lista segun su indice.
            lista.RemoveAt(0);

            foreach(var elem in lista) {
                Console.WriteLine(elem);
            }


             
        }
    }
}