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
         Console.WriteLine("1 - Exibir pokemons cadastrados");
         Console.WriteLine("0 - Sair");
         Console.Write("O que deseja fazer : ");
         escolha = Convert.ToInt32(Console.ReadLine());
         
         if (escolha == 1)
            Pokedex.ListarPokemons();

      } while (escolha != 0);
   }
}