using System;

namespace Ejercicio4Clases
{

    public interface Vehiculo
    {
        public void mover(int segs);
        public void posicion();
        public int reiniciarPosicion();
    }



    public class Auto : Vehiculo
    {
        public int pos = 0;
        public int velozmax = 40;
        public int velozactual;

        public Auto(int velocidad)
        {
            this.velozactual = velocidad;
        }

        public void mover(int segs)
        {
            if (velozactual > 40) {
                velozmax = velozactual;
                pos += velozmax * segs;
                Console.WriteLine("El auto avanzó" + pos + "metros.");
            }
            else
            {
                pos += velozmax * segs;
                Console.WriteLine("El auto avanzó" + pos + "metros.");
            }
        }

        public void posicion()
        {
            Console.WriteLine("La posicion del auto es: " + pos);
        }

        public int reiniciarPosicion()
        {
            return pos = 0;
        }
    }


    public class Bicicleta : Vehiculo
    {
        public int pos = 0;
        public int velozmax;

        public Bicicleta()
        {
            this.velozmax = 10;
        }

        public void mover(int segs)
        {
            pos += velozmax * segs;
            Console.WriteLine("La bicicleta avanzó" + pos + "metros.");

        }

        public void posicion()
        {
            Console.WriteLine("La posicion de la bicicleta es: " + pos);
        }

        public int reiniciarPosicion()
        {
            return pos = 0;
        }
    }

    public class Camion : Vehiculo
    {
        public int pos = 0;
        public int velozmax;

        public Camion()
        {
            this.velozmax = 30;
        }

        public void mover(int segs)
        {
            pos += velozmax * segs;
            Console.WriteLine("El camion avanzó" + pos + "metros.");
        }

        public void posicion()
        {
            Console.WriteLine("La posicion del camion es: " + pos);
        }

        public int reiniciarPosicion()
        {
            return pos = 0;
        }
    }

    public class Carrera
    {
        public Carrera() { };
        public void correr(Vehiculo vehiculo1, Vehiculo vehiculo2, int segundos)
        {
            vehiculo1.reiniciarPosicion();
            vehiculo2.reiniciarPosicion();

            if(vehiculo1.mover > vehiculo2.mover)
            {
                Console.WriteLine("El/La" + vehiculo1 + "ganó la carrera!");
            }
            else if(vehiculo1.mover == vehiculo2.mover)
            {
                Console.WriteLine("Empate! Nadie ganó la carrera.");
            }
            else
            {
                Console.WriteLine("El/La" + vehiculo2 + "ganó la carrera!");
            }
        }

    }

}
