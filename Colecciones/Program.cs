using System;
using System.Collections;

namespace colecciones {
    internal class Program {
        static void Main(string[] args){
            // ArrayList
            ArrayList lista = new ArrayList();
            
            lista.Add(1);
            lista.Add("juan");

            foreach (var item in lista) {
                Console.WriteLine(item);
            }
        }
    }
}