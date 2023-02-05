// Herencia.
// Herencia simple: hereda de una unica clase.
// En C# solo se puede heredar de una sola clase.
// La unica forma de tener herencia multiple es a 
// traves de una interfaz. 

using System;

namespace POO {
    public class Punto3D: Punto, IEjemplo {
        
        public int Z {get; private set;}

        // Es necesario implementar las interfaces.
        public string Nombre { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void SetZ(int value){
            if (value < 100 ){
                Z = value;
            } else {
                throw new ArgumentOutOfRangeException();
            }
        } 

        public int GetZ() {
            return Z;
        }
    }
}
