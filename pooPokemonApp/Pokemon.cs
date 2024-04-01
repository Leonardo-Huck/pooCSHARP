using System.Reflection.Metadata;

namespace pooPokemonApp;

public class Pokemon
{
    public Pokemon()
    {
        Nome = "";
        Descricao = "";
    }
    public string Nome { get; set; }
    public string Descricao { get; set; }

    public void ExibirDadosPokemon()
    {
        Console.WriteLine($"Nome do pokemon: {Nome}");
        Console.WriteLine($"Descrição do pokemon: {Descricao}");
    }
}