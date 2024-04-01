namespace pooPokemonApp;

class Program
{
    static void Main(string[] args)
    {
       Pokemon pokemon = new Pokemon();
       pokemon.Nome = "Bulbasauro".ToUpper();
       pokemon.Descricao = "Bulbasauro é um pokemon do tipo planta...";
       pokemon.ExibirDadosPokemon();
       Console.ReadKey();
    }
}