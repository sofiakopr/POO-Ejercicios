using System;
using System.Collections.Generic;

namespace JuegoCartas
{
    class Carta
    {
        public string Palo { get; }
        public string Valor { get; }

        public Carta(string palo, string valor)
        {
            Palo = palo;
            Valor = valor;
        }

        public override string ToString()
        {
            return $"{Valor} de {Palo}";
        }
    }

    class Mazo
    {
        private List<Carta> cartas;
        private Random random = new Random();

        public Mazo()
        {
            cartas = new List<Carta>();

            string[] palos = { "Espadas", "Bastos", "Oros", "Copas" };
            string[] valores =
            {
                "1", "2", "3", "4", "5", "6", "7",
                "10", "11", "12"
            };

            foreach (string palo in palos)
            {
                foreach (string valor in valores)
                {
                    cartas.Add(new Carta(palo, valor));
                }
            }
        }

        public void Barajar()
        {
            int n = cartas.Count;

            for (int i = 0; i < n; i++)
            {
                int j = random.Next(i, n);

                Carta temp = cartas[i];
                cartas[i] = cartas[j];
                cartas[j] = temp;
            }
        }

        public Carta RobarCarta()
        {
            if (cartas.Count == 0)
            {
                throw new InvalidOperationException("El mazo está vacío.");
            }

            Carta carta = cartas[0];
            cartas.RemoveAt(0);

            return carta;
        }

        public int CuantasCartasQuedan()
        {
            return cartas.Count;
        }
    }

    class Mano
    {
        private List<Carta> cartas;

        public Mano()
        {
            cartas = new List<Carta>();
        }

        public void RecibirCarta(Carta carta)
        {
            cartas.Add(carta);
        }

        public void MostrarMano()
        {
            Console.WriteLine("Cartas en mano:");

            foreach (Carta carta in cartas)
            {
                Console.WriteLine(carta);
            }

            Console.WriteLine();
        }

        public int CantidadDeCartas()
        {
            return cartas.Count;
        }
    }
}
