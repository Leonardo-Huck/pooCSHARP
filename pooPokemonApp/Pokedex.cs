namespace pooPokemonApp;

public class Pokedex
{
    public Pokedex()
    {
        InicializaLista();
    }
    public static List<PokemonPlus> Pokemons { get; private set; }

    private void InicializaLista()
    {
        Pokemons = new List<PokemonPlus>();
        PokemonPlus pokemon = new PokemonPlus("Bulbasauro", "Planta", 30);
        Pokemons.Add(pokemon);
        pokemon = new PokemonPlus("Mew", "Lendário Psiquico", 100);
        Pokemons.Add(pokemon);
        pokemon = new PokemonPlus("Mewtwo", "Lendário Psiquico", 100);
        Pokemons.Add(pokemon);
        pokemon = new PokemonPlus("Giratina", "Lendário Fantasma", 95);
        Pokemons.Add(pokemon);
        pokemon = new PokemonPlus("Flygon", "Dragão", 50);
        Pokemons.Add(pokemon);
        pokemon = new PokemonPlus("Metagross", "Metal", 60);
        Pokemons.Add(pokemon);
        pokemon = new PokemonPlus("Emolga", "Pokemom mais chato do mundo", 99);
        Pokemons.Add(pokemon);
        pokemon = new PokemonPlus("Dito", "Pokemom que copia", 50);
        Pokemons.Add(pokemon);
        pokemon = new PokemonPlus("Lucario", "Pokemon Lutador", 80);
        Pokemons.Add(pokemon);
        pokemon = new PokemonPlus("Spiritomb", "Mais chato do universo", 999);
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

    public static void ListaRapida()
    {
        Console.Clear();
        Console.WriteLine("-------POKEMONS CADASTRADOS-------");
        for (var i = 0; i<Pokemons.Count; i++ )
        {
            Console.Write("ID: " + i);
            Console.WriteLine("     Nome: "+Pokemons[i].Nome);
            Console.WriteLine();
        }
    }
}