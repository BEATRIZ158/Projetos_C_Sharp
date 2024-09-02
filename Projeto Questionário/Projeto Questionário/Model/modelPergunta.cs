using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Questionário.Model
{
    internal class modelPergunta
    {
        private int idPergunta;
        private string pergunta;
        private string alter1;
        private string alter2;
        private string alter3;
        private string alter4;
        private string resposta;
        private int idTipo;


        public int IdPergunta { get => idPergunta; set => idPergunta = value; }
        public string Pergunta { get => pergunta; set => pergunta = value; }
        public string Alter1 { get => alter1; set => alter1 = value; }
        public string Alter2 { get => alter2; set => alter2 = value; }
        public string Alter3 { get => alter3; set => alter3 = value; }
        public string Alter4 { get => alter4; set => alter4 = value; }
        public string Resposta { get => resposta; set => resposta = value; }
        public int IdTipo { get => idTipo; set => idTipo = value; }
    }
}
