using System;


namespace Ejercicio_2_POO
{

    public class Cronometro
    {
        public int segundos = 0;
        public int minutos = 0;

        public void reiniciar() {
            segundos = 0;
            minutos = 0;
        }

        public void incrementarTiempo()
        {
            if (segundos == 60)
            {
                minutos += 1;
                segundos = 0;
            }
            else
            {
                segundos += 1;
            }
        }

        public void mostrarTiempo()
        {
            Console.WriteLine(minutos + "minutos," + segundos + "segundos");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Cronometro cron = new Cronometro();

            for(int i = 0; i < 67; i++)
            {
                cron.mostrarTiempo();
                cron.incrementarTiempo();
            }
        }
    }
}
