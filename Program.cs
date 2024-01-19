
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("¡Bienvenido al juego de Truco!");

        // Paso 1: Implementar la creación de jugadores y asignarles nombres
        List<string> jugadores = CrearJugadores();

        // Paso 2: Implementar la creación de la baraja de cartas española y su mezcla
        List<string> baraja = CrearBarajaEspanola();
        baraja = MezclarBaraja(baraja);

        // Paso 3: Implementar la distribución de cartas a los jugadores
        DistribuirCartas(jugadores, baraja);

        // Paso 4: Implementar la lógica del juego, incluyendo las reglas y turnos
        JugarTruco(jugadores);

        // Paso 5: Mostrar el resultado del juego y determinar al ganador
        MostrarResultado(jugadores);

        Console.WriteLine("¡Gracias por jugar!");
        Console.ReadLine();
    }
}

