using System.Runtime.CompilerServices;
using Ejercicio3Clases;

namespace Ejercicio_3_POO
{   
    internal class Program
    {
        static void Main(string[] args)
        {
            Jugador Jugadorr = new Jugador();
            Jugadorr.correr(false, true);
            Jugadorr.descansar();

        }
    }
}
