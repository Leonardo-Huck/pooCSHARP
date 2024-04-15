using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooJogoAdivinhacao
{
    public class NovaPergunta:PerguntaJogo
    {
        public NovaPergunta():base()
        {
            Dica = "";
        }
        public NovaPergunta(string pergunta, string resposta, string dica):base(pergunta, resposta)
        {
            Dica = dica;
            
        }
        public string Dica { get; set; }

    }
}
