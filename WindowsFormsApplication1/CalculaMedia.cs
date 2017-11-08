using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class CalculaMedia
    {
        public string NomeAluno { get; set; }
        public int ContadorProvas { get; set; }
        public int ContadorPontos { get; set; }
        public int SomaPontos { get; set; }
        public decimal SomaProvas { get; set; }

        public void InserirNotaProva(decimal nota)
        {
            if (this.ContadorPontos > 4) throw new Exception("Excedeu o limite de provas no ano");
            this.ContadorProvas++;
            this.SomaProvas += nota;
        }

        public void InserirPonto(decimal ponto)
        {
            if (this.ContadorPontos > 4) throw new Exception("Excedeu o limite de pontos no ano");
            this.ContadorPontos++;
            this.SomaPontos++;
        }

        public decimal CalcularMedia()
        {
            decimal retorno = (SomaProvas + SomaPontos) / 4;
            return retorno;
        }
    }
}
