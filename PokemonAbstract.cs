//Espacio de nombre todas las clases usadas en el proyecto
namespace BatallaPokemon;
 
public abstract class PokemonAbstract : InterfazPokemon
{
    // Propiedades con letras mayúsculas y miembros get públicos
    public string Nombre { get; private set; }
    public string Tipo { get; private set; }
    public int[] Ataques { get; private set; } // 3 ataques puntaje 0 y 40;
    public int Defensa { get; private set; } // defensa 10 y 35;

    // Constructor
    public PokemonAbstract(string nombre, string tipo, int[] ataques, int defensa)
    {
        Nombre = nombre;
        Tipo = tipo;
        Ataques = ataques;
        Defensa = defensa;
    }

    // Métodos abstractos
    public abstract int Atacar();

    public abstract double Defender();
}