  namespace AHoraDoPitch
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Alarme alarme = new Alarme();
            string resposta = "S";
            while(resposta != "N")
            {
                Console.Clear();
                Console.WriteLine("A hora do Pitch!");

                Console.Write("\nInforme a duracao do Pitch: ");
                int tempo = Convert.ToInt32(Console.ReadLine());
                alarme.Tempo = tempo;
                alarme.Iniciar();
                Console.WriteLine("Que pena!! Seu tempo acabou!!");

                Console.Write("\nExecutar o programa novamente S/N ? ");
                resposta = Console.ReadLine().ToUpper();

            }

            alarme.Mario();
            
        }
    }
}
