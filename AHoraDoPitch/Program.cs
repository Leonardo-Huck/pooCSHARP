  namespace AHoraDoPitch
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            string resposta = "S";
            while(resposta != "N")
            {
                Console.Clear();
                Console.WriteLine("A hora do Pitch!");

                Console.Write("\nInforme a duracao do Pitch: ");
                int tempo = Convert.ToInt32(Console.ReadLine());

                Console.Write("Informe a frequencia do Beep de 1 a 1000: ");
                int frequencia = Convert.ToInt32(Console.ReadLine());

                Console.Write("Informe a duracao do Beep de 1 a 100: ");
                int duracao = Convert.ToInt32(Console.ReadLine());
                
                Alarme alarme = new Alarme(tempo,frequencia, duracao);
                alarme.Iniciar();
                Console.WriteLine("\nQue pena!! Seu tempo acabou!!");

                Console.Write("\nExecutar o programa novamente S/N ? ");
                resposta = Console.ReadLine().ToUpper();
            }           
        }
    }
}
