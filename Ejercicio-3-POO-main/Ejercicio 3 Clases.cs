using System;

namespace Ejercicio3Clases
{
    public interface Jugadorx
    {
        public bool correr(int mins);
        public bool cansado();
        public void descansar(int mins);
    }
    public class Jugador : Jugadorx
    {
        public bool amateur;
        public bool profesional;
        public bool jugadorCansado = false;

        public Jugador(bool noob, bool pro)
        {
            this.amateur = noob;
            this.profesional = pro;
        }

        public int minutos = 0;

        public bool correr(int mins)
        {
            if (amateur)
            {
                minutos = 20;
                if (minutos > 0 && minutos <= mins)
                {
                    while (minutos != 0)
                    {
                        mins--;
                        minutos--;
                    }
                    if (minutos == 0 && mins > minutos)
                    {
                        Console.WriteLine("El jugador amateur esta cansado.");
                        return cansado();
                    }
                }
            }
            else if (profesional)
            {
                minutos = 40;
                if (minutos > 0 && minutos <= mins)
                {
                    while (minutos != 0)
                    {
                        mins--;
                        minutos--;
                    }
                    if (minutos == 0 && mins > minutos)
                    {
                        Console.WriteLine("El jugador profesional esta cansado.");
                        return cansado();
                    }
                }
            }
        }

        public bool cansado()
        {
            return jugadorCansado = true;
        }

        public void descansar()
        {
            if (amateur)
            {
                minutos = 20;
                Console.WriteLine("El jugador amateur ha descansado!");
            }
            else if (profesional)
            {
                minutos = 40;
                Console.WriteLine("El jugador profesional ha descansado!");
            }
        }
    }
}
