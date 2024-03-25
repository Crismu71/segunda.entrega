//Espacio de nombre todas las clases usadas en el proyecto
namespace BatallaPokemon;
 
//clase que hereda de la clase adstracta
public class Pokemon : PokemonAbstract
{
    //Constructor pide los datos y lo manda al constructor de la clase abstracta
   public Pokemon(string nombre, string tipo, int[] ataques, int defensa)
    : base(nombre, tipo, ataques, defensa)
    {
    }

    //Implemento metodos abstractos
    public override int Atacar()
    {
        Random rand = new Random();
        int ataqueSeleccionado = rand.Next(Ataques.Length);//genero numero aleatorio del 1 al3
        return Ataques[ataqueSeleccionado] * (rand.Next(2)); // Multiplica por 0 o 1-- ran.Next(2)-- genera un numero ya sea 0 ó 1

        //retorna puntaje de ataque------
    }

    public override double Defender()
    {
        Random rand = new Random();
        double factorDefensa = (rand.Next(2) == 0) ? 0.5 : 1.0; //de manera aleatorio asigno puntaje de defensa 
        return Defensa * factorDefensa;
        //retorna puntaje de Defensa------
    }
}