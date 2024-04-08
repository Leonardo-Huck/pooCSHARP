using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeAnimais
{
	public enum TipoAnimal {Cachorro, Gato, Peixe};
    public class Animal
    {
		private string nome;

		public string Nome
		{
			get { return nome; }
			set { nome = value.ToUpper(); }
		}

		private TipoAnimal tipo;

		public TipoAnimal Tipo
		{
			get { return tipo; }
			set { tipo = value; }
		}

	}
}
