
namespace Truco
{
    public class Jugador
    {
        public string Nombre { get; set; }
        public List<Carta> Mano { get; set; }

        public Jugador(string nombre)
        {
            Nombre = nombre;
            Mano = new List<Carta>(3);
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
                    Cartas.Add(new Carta(palo.ToString(), valor.ToString()));
                }
            }
            MezclarBaraja();
        }

        public void MezclarBaraja()
        {
            try
            {
                Random rnd = new Random();
                this.Cartas = Cartas.OrderBy(x => rnd.Next()).ToList();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void DistribuirCartas(List<Jugador> jugadores)
        {
            MezclarBaraja();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < jugadores.Count; j++)
                {
                    jugadores[j].Mano.Add(Cartas[0]);
                    Cartas.RemoveAt(0);
                }
            }
        }
    }
}