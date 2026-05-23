using System.Runtime.CompilerServices;
using Ejercicio4Clases;
namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto Fiat = new Auto(45);
            Bicicleta bici = new Bicicleta();
            Camion camion = new Camion();
            bici.mover(20);
            bici.posicion();
            bici.mover(30);
            bici.posicion();
            Carrera carrera = new Carrera();
            carrera.correr(Fiat, bici, 30);

        }
    }
}
