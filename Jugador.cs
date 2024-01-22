namespace Truco
{

    public class Jugador
    {
        public string Nombre { get; set; }
        public List<Carta> Mano { get; set; }

        public Jugador(string nombre)
        {
            Nombre = nombre;
            Mano = new List<Carta>();
        }

    }

    public class Carta
    {
        public string Palo { get; set; }
        public string Valor { get; set; }

        public Carta(string palo, string valor)
        {
            Palo = palo;
            Valor = valor;
        }

    }

    public class Baraja
    {
        public List<Carta> Cartas { get; set; }
        string[] palos = { "ORO", "COPA", "BASTO", "ESPADA" };
        string[] valores = { "1", "2", "3", "4", "5", "6", "7", "10", "11", "12" };


        public Baraja()
        {
            Cartas = new List<Carta>();
            foreach (var palo in palos)
            {
                foreach (var valor in valores)
                {
                    Cartas.Add(new Carta(palo, valor));
                }
            }
            MezclarBaraja();
        }

        public void MezclarBaraja()
        {
            Random rnd = new Random();
            Cartas = Cartas.OrderBy(x => rnd.Next()).ToList();
        }

        public void DistribuirCartas(List<Jugador> jugadores)
        {
            int i = 0;
            foreach (var carta in Cartas)
            {
                jugadores[i].Mano.Add(carta);
                i++;
                if (i == jugadores.Count)
                {
                    i = 0;
                }
            }
        }
    }
}