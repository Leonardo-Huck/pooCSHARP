using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooJogoAdivinhacao
{
    public class PerguntaJogo
    {
        public PerguntaJogo()
        {
            Pergunta = "";
            Resposta = "";
        }

        public PerguntaJogo(string pergunta, string resposta)
        {
            Pergunta = pergunta;
            Resposta = resposta;
        }
        public string Pergunta { get; set; }

        public string Resposta { get; set; }


    }
}
