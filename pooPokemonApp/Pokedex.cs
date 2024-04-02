namespace pooPokemonApp;

public class Pokedex
{
    public Pokedex()
    {
        InicializaLista();
    }
    public static List<Pokemon> Pokemons { get; private set; }

    private void InicializaLista()
    {
        Pokemons = new List<Pokemon>();
        Pokemon pokemon = new Pokemon("Bulbasauro", "Planta");
        Pokemons.Add(pokemon);
        pokemon = new Pokemon("Mew", "Lendário Psiquico");
        Pokemons.Add(pokemon);
        pokemon = new Pokemon("Mewtwo", "Lendário Psiquico");
        Pokemons.Add(pokemon);
        pokemon = new Pokemon("Giratina", "Lendário Fantasma");
        Pokemons.Add(pokemon);
        pokemon = new Pokemon("Flygon", "Dragão");
        Pokemons.Add(pokemon);
        pokemon = new Pokemon("Metagross", "Metal");
        Pokemons.Add(pokemon);
        pokemon = new Pokemon("Emolga", "Pokemom mais chato do mundo");
        Pokemons.Add(pokemon);
        pokemon = new Pokemon("Dito", "Pokemom que copia");
        Pokemons.Add(pokemon);
        pokemon = new Pokemon("Lucario", "Pokemon Lutador");
        Pokemons.Add(pokemon);
        pokemon = new Pokemon("Spiritomb", "Mais chato do universo");
        Pokemons.Add(pokemon);
    }

    public static void ListarPokemons()
    {
        Console.Clear();
        Console.WriteLine("-------POKEMONS CADASTRADOS-------");
        foreach (var pokemon in Pokemons)
        {
            pokemon.ExibirDadosPokemon();
            Console.WriteLine();
        }
        
        Console.ReadKey();
    }
}