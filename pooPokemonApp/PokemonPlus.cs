using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokemonApp
{
    public class PokemonPlus:Pokemon
    {
        public PokemonPlus():base()
        {
            Poder = 0;
        }

        public PokemonPlus(string nome, string descricao, int poder):base(nome, descricao)
        {
            Poder = poder;
        }
        public int Poder { get; set; }

        public void ExibirDadosPokemonPlus()
        {
            Console.WriteLine($"Nome do pokemon: {Nome}");
            Console.WriteLine($"Descrição do pokemon: {Descricao}");
            Console.WriteLine($"Poder do pokemon: {Poder}");
        }
    }
}
