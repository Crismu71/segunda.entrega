//Uso el espacio de nombre para usar todas las clases de proyecto
using BatallaPokemon;

 
public class Program
{
    public static void Main(string[] args)
    {
        string? entrada;
        int entradaInt;
        int defensaInt;
        //datos del pokemon #1
        string? nombrePokemon1;
        string? tipoPokemon1;
        int[] ataquesPokemon1=new int[3];
        int defensaPokemon1=0;
        int puntosPokemon1 = 0;
          
        //datos del pokemon #2
        string? nombrePokemon2;
        string? tipoPokemon2;
        int[] ataquesPokemon2=new int[3];
        int defensaPokemon2=0;
        int puntosPokemon2 = 0;
       

        Console.WriteLine("¡¡¡Bienvenido a la batalla de Pokemones!!!");
        Console.WriteLine("__________________________________________");
        Console.WriteLine("Ingrese los siguientes datos del Pokemon # 1");
        Console.WriteLine("Ingrese Nombre del pokemon #1: ");
        nombrePokemon1=Console.ReadLine();
        Console.WriteLine("Ingrese el Tipo de pokemon #1: ");
        tipoPokemon1=Console.ReadLine();
        int i;
        for( i = 0; i <3; i++)
        {
            //Aqui valido que los puntajes de ataque sea correcto entre 0 y 40
            do
            {
                Console.WriteLine("Ingrese ataques del Pokémon #1 -- Ataque #" + (i + 1).ToString());
                entrada = Console.ReadLine();

                if (int.TryParse(entrada, out entradaInt) && entradaInt >= 0 && entradaInt <= 40)
                {
                    ataquesPokemon1[i] = entradaInt;
                }
                else
                {
                    Console.WriteLine("Ingreso un valor no válido o fuera de rango. Debe ser un número entre 0 y 40. Intente nuevamente.");
                }
            } while (entradaInt < 0 || entradaInt > 40);
        } 

        //Aqui valido que el puntaje de la defensa sea correcto entre 10 y 35
        do
        {
            Console.WriteLine("Ingrese la defensa del Pokémon #1 (debe estar en el rango de 10 a 35):");
            string? entradaDefensa = Console.ReadLine();

            if (int.TryParse(entradaDefensa, out defensaInt) && defensaInt >= 10 && defensaInt <= 35)
            {
               
                defensaPokemon1 = defensaInt;
            }
            else
            {
                Console.WriteLine("Ingreso un valor no válido o fuera de rango. Debe ser un número entre 10 y 35. Intente nuevamente.");
            }
        }   while (defensaInt < 10 || defensaInt > 35);

        Console.WriteLine("__________________________________________");
        Console.WriteLine("Ingrese los siguientes datos del Pokemon # 2");
        Console.WriteLine("Ingrese Nombre del pokemon #2: ");
        nombrePokemon2=Console.ReadLine();
        Console.WriteLine("Ingrese el Tipo de pokemon #2: ");
        tipoPokemon2=Console.ReadLine();
    
        for(i = 0; i <3; i++)
        {
            //Aqui valido que los puntajes de ataque sea correcto entre 0 y 40
            do
            {
                Console.WriteLine("Ingrese ataques del Pokémon #2 -- Ataque #" + (i + 1).ToString());
                entrada = Console.ReadLine();

                if (int.TryParse(entrada, out entradaInt) && entradaInt >= 0 && entradaInt <= 40)
                {
                    ataquesPokemon2[i] = entradaInt;
                }
                else
                {
                    Console.WriteLine("Ingreso un valor no válido o fuera de rango. Debe ser un número entre 0 y 40. Intente nuevamente.");
                }
            } while (entradaInt < 0 || entradaInt > 40);
        } 

        //Aqui valido que el puntaje de la defensa sea correcto entre 10 y 35
        do
        {
            Console.WriteLine("Ingrese la defensa del Pokémon #1 (debe estar en el rango de 10 a 35):");
            string? entradaDefensa = Console.ReadLine();

            if (int.TryParse(entradaDefensa, out defensaInt) && defensaInt >= 10 && defensaInt <= 35)
            {
               
                defensaPokemon2 = defensaInt;
            }
            else
            {
                Console.WriteLine("Ingreso un valor no válido o fuera de rango. Debe ser un número entre 10 y 35. Intente nuevamente.");
            }
        }   while (defensaInt < 10 || defensaInt > 35);

        //Creo los pokemones 
        Pokemon pokemon1 = new Pokemon(nombrePokemon1, tipoPokemon1, ataquesPokemon1, defensaPokemon1);
        Pokemon pokemon2 = new Pokemon(nombrePokemon2, tipoPokemon2, ataquesPokemon2, defensaPokemon2);

        Console.WriteLine("__________________________________________");
        Console.WriteLine("Puntaje de la batalla de pokemones");

        // Realizar la batalla durante 3 turnos
        for (int turno = 1; turno <= 3; turno++)
        {
            Console.WriteLine($"Turno {turno}:");

            // Ataque del Pokémon 1
            int ataque1 = pokemon1.Atacar();
            double defensa1 = pokemon1.Defender();

            // Ataque del Pokémon 2
            int ataque2 = pokemon2.Atacar();
            double defensa2 = pokemon2.Defender();

            // Calcular daño causado por el Pokémon 1
            int danio1 = (int)(ataque2 - defensa1);

            // Calcular daño causado por el Pokémon 2
            int danio2 = (int)(ataque1 - defensa2);

            // Mostrar resultados del turno
            Console.WriteLine($"{pokemon1.Nombre} atacó con un poder de {ataque1}");
            Console.WriteLine($"{pokemon2.Nombre} atacó con un poder de {ataque2}");

            if (danio1 > 0)
            {
                Console.WriteLine($"{pokemon1.Nombre} causó {danio1} puntos de daño a {pokemon2.Nombre}");
                puntosPokemon1++;
            }
            else
            {
                Console.WriteLine($"{pokemon1.Nombre} no causó daño a {pokemon2.Nombre}");
            }

            if (danio2 > 0)
            {
                Console.WriteLine($"{pokemon2.Nombre} causó {danio2} puntos de daño a {pokemon1.Nombre}");
                puntosPokemon2++;
            }
            else
            {
                Console.WriteLine($"{pokemon2.Nombre} no causó daño a {pokemon1.Nombre}");
            }

            Console.WriteLine();
        }

        // Determinar el resultado de la batalla
        if (puntosPokemon1 > puntosPokemon2)
        {
            Console.WriteLine($"{pokemon1.Nombre} gana la batalla!");
        }
        else if (puntosPokemon2 > puntosPokemon1)
        {
            Console.WriteLine($"{pokemon2.Nombre} gana la batalla!");
        }
        else
        {
            Console.WriteLine("La batalla termina en empate.");
        }


    }
}

