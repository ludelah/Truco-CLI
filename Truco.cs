
namespace Truco
{
    public class Partido
    {

        List<Jugador> jugadores;
        Baraja baraja;

        public Partido(List<Jugador> jugadores, Baraja baraja)
        {
            this.jugadores = jugadores;
            this.baraja = baraja;
        }
        public void JugarTruco()
        {
            // GAME LOOP
            do
            {
                Ronda ronda = new Ronda(jugadores, baraja);
                ronda.JugarRonda();
            } while (true);
            // implementar lógica de fin de juego
            
            //Paso 4: Implementar la lógica del juego, incluyendo las reglas y turnos
            //Paso 4.1: Implementar la lógica de las reglas
            //Paso 4.2: Implementar la lógica de las rondas
            //Paso 4.3: Implementar la lógica de los turnos
            //Paso 4.4: Implementar tirada de cartas por turno
            //Paso 4.5: Implementar cantos y apuestas
            //Paso 4.5.1: Implementar envido/real envido/falta envido/flor
            //Paso 4.5.2: Implementar truco/retruco/vale cuatro
            //Paso 4.5.3: Implementar respuestas a los cantos (quiero/no quiero)
            //Paso 4.6: Implementar la lógica de los puntos
        }
    }

    public class Ronda
    {
        List<Jugador> jugadores;
        Baraja baraja { get; set;};

        public Ronda(List<Jugador> jugadores, Baraja baraja)
        {
            this.jugadores = jugadores;
            this.baraja = baraja;
        }

        public void JugarRonda()
        {
            baraja.DistribuirCartas(jugadores);
            foreach (var carta in baraja.Cartas)
                Console.WriteLine(carta.Valor + " " + carta.Palo);

            Console.WriteLine($"{jugadores[0].Nombre} tiene: \n {jugadores[0].Mano[0].Valor} de {jugadores[0].Mano[0].Palo}, \n {jugadores[0].Mano[1].Valor} de {jugadores[0].Mano[1].Palo}, \n {jugadores[0].Mano[2].Valor} de {jugadores[0].Mano[2].Palo}");
            Console.WriteLine($"{jugadores[1].Nombre} tiene: \n {jugadores[1].Mano[0].Valor} de {jugadores[1].Mano[0].Palo}, \n {jugadores[1].Mano[1].Valor} de {jugadores[1].Mano[1].Palo}, \n {jugadores[1].Mano[2].Valor} de {jugadores[1].Mano[2].Palo}");

        }
    }
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
