using System.Security.Cryptography.X509Certificates;

namespace Ejercicio_1_Objetos
{
    public class Semaforo
    {
        public string colorActual;
        public int tiempoColor;

        public bool modoIntermitente;
        public bool luzEncendida; // para intermitente

        public Semaforo(string colorInicial)
        {
            colorActual = colorInicial;
            tiempoColor = 0;
            modoIntermitente = false;
            luzEncendida = true;
        }

        public void pasoDelTiempo(int segundos)
        {
            for (int i = 0; i < segundos; i++){
                if (modoIntermitente){
                    // alterna cada segundo
                    luzEncendida = !luzEncendida;
                }
                else{
                    tiempoColor++;

                    switch (colorActual){
                        case "Rojo":
                            if (tiempoColor >= 30)
                            {
                                colorActual = "Rojo + Amarillo";
                                tiempoColor= 0;
                            }
                            break;

                        case "Rojo + Amarillo":
                            if (tiempoColor >= 2)
                            {
                                colorActual = "Verde";
                                tiempoColor = 0;
                            }
                            break;

                        case "Verde":
                            if (tiempoColor >= 20)
                            {
                                colorActual = "Amarillo";
                                tiempoColor = 0;
                            }
                            break;

                        case "Amarillo":
                            if (tiempoColor >= 2)
                            {
                                colorActual = "Rojo";
                                tiempoColor = 0;
                            }
                            break;
                    }
                }
            }
        }

        public void mostrarColor()
        {
            if (modoIntermitente)
            {
                Console.WriteLine(luzEncendida ? "Amarillo" : "Apagado");
            }
            else
            {
                Console.WriteLine(colorActual);
            }
        }

        public void ponerEnIntermitente()
        {
            modoIntermitente = true;
            luzEncendida = true;
        }

        public void sacarDeIntermitente()
        {
            modoIntermitente = false;
            tiempoColor = 0; // reinicia el ciclo desde el estado actual
        }


        class Program
        {
            static void Main()
            {
                Semaforo semaforo = new Semaforo("Verde");

                for (int i = 0; i < 25; i++)
                {
                    semaforo.mostrarColor();
                    semaforo.pasoDelTiempo(1);
                }

                Console.WriteLine("Modo intermitente...");
                semaforo.ponerEnIntermitente();

                for (int i = 0; i < 5; i++)
                {
                    semaforo.mostrarColor();
                    semaforo.pasoDelTiempo(1);
                }

                Console.WriteLine("Volviendo a normal...");
                semaforo.sacarDeIntermitente();

                for (int i = 0; i < 10; i++)
                {
                    semaforo.mostrarColor();
                    semaforo.pasoDelTiempo(1);
                }
            }
        }

    }
}

