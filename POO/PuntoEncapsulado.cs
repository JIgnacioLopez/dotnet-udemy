// Encapsulacion
// sirve para poder controlar las variables 
// de las instancias para que no entren en conflicto 
// con la funcionalida de la clase. 

using System;

namespace POO {
    public class PuntoEncapsulado {
        
        // Esto puede ser remplazado simplemante declarando {get;set;} con las
        // variables de estado.
        /*
        private int X;
        private int Y;
        public void SetX(int value){
            if (value < 100 ){
                X = value;
            } else {
                throw new ArgumentOutOfRangeException();
            }
        }    

        public void SetY(int value) {
            if (value > 50) {
                Y = value;
            } else {
                throw new ArgumentOutOfRangeException();
            }
        }

        public int GetX() {
            return X;
        }

        public int GetY() {
            return Y;
        }
        */

        public int X {get; private set;}
        public int Y {get; private set;}


        public void setXPrivate(int value) {
            if (value <100) {
                X = value;
            } else{
                throw new ArgumentOutOfRangeException();
            }
        }

    }
}
