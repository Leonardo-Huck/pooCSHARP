using ControleDeAnimais;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Controle de Animais");
        Console.WriteLine("-------------------");
        
        int tl = 0;
        int totalCachorro = 0, totalGato = 0, totalPeixe = 0;

        try
        {
            Console.Write("Quantos animais deseja cadastrar?   ");
            tl = Convert.ToInt32(Console.ReadLine());
            if (tl < 0) tl = 0;
        }
        catch
        {
            tl = 0;
        }

        Animal[] animals = new Animal[tl];

        for (int i = 0; i < animals.Length; i++)
        {
            animals[i] = new Animal();
            Console.WriteLine($"Informe o nome do {i + 1}º animal: ");
            animals[i].Nome = Console.ReadLine();
            Console.WriteLine($"Informe o tipo do {i + 1}º animal (Cachorro - 0, Gato - 1 ou Peixe - 2): ");
            int tipoAnimal = 0;
            try
            {
                tipoAnimal = Convert.ToInt32(Console.ReadLine());
                if (tipoAnimal < 0 || tipoAnimal > 2) tipoAnimal = 2;
            }
            catch
            {
                tipoAnimal = 2;
            }

            animals[i].Tipo = (TipoAnimal)tipoAnimal;

            if (animals[i].Tipo == TipoAnimal.Cachorro) totalCachorro++;
            if (animals[i].Tipo == TipoAnimal.Gato) totalGato++;
            if (animals[i].Tipo == TipoAnimal.Peixe) totalPeixe++;
            Console.Clear();
        }

        Console.WriteLine("Total de Animais:");
        Console.WriteLine($"Cachorros: {totalCachorro}\nGatos: {totalGato}\nPeixes: {totalPeixe}");

        Console.WriteLine("\nAnimais Cadastrados:");
        foreach (Animal animal in animals)
        {
            Console.WriteLine($"{animal.Nome}");
            Console.WriteLine($"{animal.Tipo}\n");
        }
    }
}