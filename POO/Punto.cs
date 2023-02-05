using System;

namespace POO {
    public class Punto {

        // estas propiedades son publicas por lo que cualquier 
        //parte del codigo puede acceder a ellas y modificarlas.
        // public int X;
        // public int Y;

        public int X {get; private set;}
        public int Y {get; private set;}
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
    }
}
