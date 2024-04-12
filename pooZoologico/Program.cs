namespace pooZoologico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<AnimalPlus> lista = new List<AnimalPlus>();

            int countCar = 0, countHer = 0;

            Console.WriteLine("------ Controle de Animais do zoologico -------");
            
            for (int i = 0; i < 4; i++)
            { 
                AnimalPlus animal = new AnimalPlus();
                Console.WriteLine($"Informe os dados do {i + 1} animal");
                Console.Write("Informe a especie: ");
                animal.Especie = Console.ReadLine();
                Console.Write("Informe o peso: ");
                animal.Peso = Convert.ToDouble(Console.ReadLine());
                Console.Write("Informe o tipo de alimentacao (Carnivoro ou Herbivoro) : ");
                animal.TipoAlimentacao = Console.ReadLine();

                if (animal.TipoAlimentacao == "Carnivoro")
                    countCar++;
                else
                    countHer++;

                lista.Add(animal);
            }

            Console.WriteLine($"O total de animais carnivoros e de {countCar}");
            Console.WriteLine($"O total de animais herbivoros e de {countHer}");

            Console.ReadKey();
        }
    }
}
