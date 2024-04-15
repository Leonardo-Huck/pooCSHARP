using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooZoologico
{
    public class Animal
    {
        public Animal()
        {
            this.Especie = "";
            this.Peso = 0;
        }
        public Animal(String especie, Double peso)
        {
            this.Especie = especie;
            this.Peso = peso;
        }
        public String Especie { get; set; }
        public Double Peso { get; set; }
    }
}
