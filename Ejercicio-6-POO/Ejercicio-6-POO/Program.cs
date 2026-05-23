using JuegoCartas;
namespace Ejercicio_6_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Mazo mazo = new Mazo();

            mazo.Barajar();

            Mano jugador1 = new Mano();
            Mano jugador2 = new Mano();

            for (int i = 0; i < 3; i++)
            {
                jugador1.RecibirCarta(mazo.RobarCarta());
                jugador2.RecibirCarta(mazo.RobarCarta());
            }

            Console.WriteLine("Jugador 1:");
            jugador1.MostrarMano();

            Console.WriteLine("Jugador 2:");
            jugador2.MostrarMano();

            Console.WriteLine("Cartas restantes en el mazo: " + mazo.CuantasCartasQuedan());
            
        }
    }

}
