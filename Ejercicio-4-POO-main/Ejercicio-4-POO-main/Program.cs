using System.Runtime.CompilerServices;

namespace Ejercicio4
{
    public interface Vehiculo
    {
        public void mover(int segs);
        public void posicion();
        public void reiniciarPosicion();
    }

    public class Auto : Vehiculo
    {
        public int velozmax;
        public int pos = 0;

        public void mover(int segs)
        {
            pos = velozmax * segs;
        }

        public void posicion()
        {
            Console.WriteLine("La posicion del auto es: " + pos);
        }

        public void reiniciarPosicion()
        {
            pos = 0;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
