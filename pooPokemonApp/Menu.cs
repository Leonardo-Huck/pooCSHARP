namespace pooPokemonApp;

public class Menu
{
   public static void Show()
   {
      var escolha = 100;
      do
      {
         Console.Clear();
         Console.WriteLine("------ POKEDEX ------");
         Console.WriteLine("2 - Batalhar");
         Console.WriteLine("1 - Exibir pokemons cadastrados na pokedex");
         Console.WriteLine("0 - Sair");
         Console.Write("O que deseja fazer : ");
         escolha = Convert.ToInt32(Console.ReadLine());
         
         if (escolha == 1)
            Pokedex.ListarPokemons();
         if(escolha == 2)
         {
            Pokedex.ListaRapida();
            Console.WriteLine("----------------------------");
            Console.Write("\nDigite o ID do Pokemon: ");

            int id = Convert.ToInt32(Console.ReadLine());
            PokemonPlus player = Pokedex.Pokemons[id];
            Random random = new Random();
            id = random.Next(0,Pokedex.Pokemons.Count);
            PokemonPlus NPC = Pokedex.Pokemons[id];

            Console.Clear();
            Console.WriteLine("------BATALHA POKEMOM------");
            Console.WriteLine();
            Console.WriteLine(" Dados do seu Pokemom:\t\t\t\t Dados do Pokemom do Oponente: ");
            Console.WriteLine($" Nome: {player.Nome}\t\t\t\t\t Nome:{NPC.Nome}");
            Console.WriteLine($" Poder: {player.Poder}\t\t\t\t\t Poder:{NPC.Poder}");

            Console.Write("Batalhar");
            for(int i = 0; i < 3; i++)
                {
                    Thread.Sleep(2000);
                    Console.Write("!");
                    Console.Beep(3000, 60);
                }

            Console.WriteLine();
            if (player.Poder >= NPC.Poder)
                Console.WriteLine("\nParabens!! Voce Venceu!!");
            else
                Console.WriteLine("\nQue pena!! Voce Perdeu!");
            
            Console.ReadKey();
         }

      } while (escolha != 0);
   }
}