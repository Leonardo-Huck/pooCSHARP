namespace pooJogoAdivinhacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<NovaPergunta> perguntas;
            perguntas = CriarPerguntas();
            Random random = new Random();
            int posicao = random.Next(0, perguntas.Count);
            NovaPergunta pergunta = perguntas[posicao];
            
            
            Console.WriteLine("----------------------- O que é, o que é? -----------------------");
            Console.WriteLine("Tente Adivinhar:");
            Console.WriteLine(pergunta.Pergunta);

            string resposta = "";
            int count = 0;

            while (resposta.ToUpper() != pergunta.Resposta.ToUpper())
            {
                if (count < 3)
                {
                    Console.Write("Resposta: ");
                    resposta = Console.ReadLine();
                    Console.WriteLine("Tente denovo");
                    count++;
                }
                else if (count >= 3)
                {
                    Console.WriteLine("Aqui vai uma dica!");
                    Console.WriteLine(pergunta.Dica);
                    Console.Write("Resposta: ");
                    resposta = Console.ReadLine();
                    Console.WriteLine("Tente denovo");
                    count++;
                }
            }

            Console.WriteLine("Parabens!!!!!!!! Resposta Correta!");
            Console.WriteLine($"Numero de tentativas foi de {count}.");


        }

        static List<NovaPergunta> CriarPerguntas()
        {
            List<NovaPergunta> lista = new List<NovaPergunta>();
            NovaPergunta pergunta = new NovaPergunta("O que é, o que é? Tem cabeça e tem dente, não é bicho e nem é gente.", "alho", "Muito utilizado para matar vampiros");
            lista.Add(pergunta);
            pergunta = new NovaPergunta("O que é, o que é? Dá muitas voltas e não sai do lugar.", "relogio", "Voce olha pra nao se atrasar");
            lista.Add(pergunta);
            pergunta = new NovaPergunta("O que é, o que é? Feito para andar e não anda.", "rua", "Voce usa pra chegar em casa");
            lista.Add(pergunta);
            pergunta = new NovaPergunta("O que é, o que é? Não se come, mas é bom para se comer.", "talher", "Geralmente fica na gaveta");
            lista.Add(pergunta);
            pergunta = new NovaPergunta("O que é, o que é? Quanto mais rugas têm mais novo é.", "pneu", "Tem no carro e na barriga");
            lista.Add(pergunta);

            //Adicionar direto muito + rapido
            lista.Add(new NovaPergunta("O que é, o que é? Nunca volta, embora nunca tenha ido.", "passado", "O que ficou pra tras"));
            lista.Add(new NovaPergunta("O que é, o que é? Anda com os pés na cabeça.", "piolho", "E uma pia com olho"));
            lista.Add(new NovaPergunta("O que é, o que é? Quanto mais se tira mais se aumenta.", "buraco", "Tem um monte na rua"));
            lista.Add(new NovaPergunta("O que é, o que é? Fica cheio durante o dia e vazio durante a noite.", "sapato", "Fica no pe"));
            lista.Add(new NovaPergunta("O que é, o que é? Mesmo atravessando o rio não se molha.", "ponte", "Fica em cima do rio"));
            return lista;
        }
    }
}
