
using Truco;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("¡Bienvenido al juego de Truco!");

        // Paso 1: Crear instancias de jugadores y asignarles un nombre
        Console.WriteLine("Ingrese el nombre del jugador 1: ");
        Jugador j1 = new Jugador(Console.ReadLine().ToUpper());

        Console.WriteLine("Ingrese el nombre del jugador 2: ");
        Jugador j2 = new Jugador(Console.ReadLine().ToUpper());

        List<Jugador> jugadores = new List<Jugador>() { j1, j2 };
        //TODO: EXCEPTION HANDLING

        Console.WriteLine($"{j1.Nombre} vs {j2.Nombre}");

        escribirLinea(); // <--- Esto es solo para que se vea más lindo en la consola
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

        // Paso 2: Crear instancia de baraja de cartas mezclada
        Baraja baraja = new Baraja();

        foreach (var carta in baraja.Cartas)
            Console.WriteLine(carta.Valor + " " + carta.Palo);

        escribirLinea(); // <--- Esto es solo para que se vea más lindo en la consola
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

        //// Paso 3: Implementar la distribución de cartas a los jugadores
        baraja.DistribuirCartas(jugadores);

        Console.WriteLine($"{j1.Nombre} tiene: \n {j1.Mano[0].Valor} de {j1.Mano[0].Palo}, \n {j1.Mano[1].Valor} de {j1.Mano[1].Palo}, \n {j1.Mano[2].Valor} de {j1.Mano[2].Palo}");
        Console.WriteLine($"{j2.Nombre} tiene: \n {j2.Mano[0].Valor} de {j2.Mano[0].Palo}, \n {j2.Mano[1].Valor} de {j2.Mano[1].Palo}, \n {j2.Mano[2].Valor} de {j2.Mano[2].Palo}");

        escribirLinea(); // <--- Esto es solo para que se vea más lindo en la consola
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        
        //// Paso 4: Implementar la lógica del juego, incluyendo las reglas y turnos
        //JugarTruco(jugadores);
        //
        //// Paso 5: Mostrar el resultado del juego y determinar al ganador
        //MostrarResultado(jugadores);

        Console.WriteLine("¡Gracias por jugar!");
        Console.ReadLine();
    }

    static void escribirLinea()
    {
        Console.WriteLine(" - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
    }
}

