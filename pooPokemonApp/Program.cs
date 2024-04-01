namespace pooPokemonApp;

class Program
{
    static void Main(string[] args)
    {
        Pokedex pokedex = new Pokedex();
        Console.WriteLine("-------POKEMONS CADASTRADOS-------");
        foreach (var pokemon in pokedex.Pokemons)
        {
            Pokemon p = pokemon;
            p.ExibirDadosPokemon();
            Console.WriteLine();
        }
        
        Console.ReadKey();
    }
}