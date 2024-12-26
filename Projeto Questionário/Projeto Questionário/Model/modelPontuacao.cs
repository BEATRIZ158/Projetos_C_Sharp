using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Questionário.Model
{
    internal class modelPontuacao
    {
        private int idTentativa;
        private int idUsuario;
        private int totalAcertos;
        private DateTime dataTentativa;
        private int totalErros;

        public int IdTentativa { get => idTentativa; set => idTentativa = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int TotalAcertos { get => totalAcertos; set => totalAcertos = value; }
        public DateTime DataTentativa { get => dataTentativa; set => dataTentativa = value; }
        public int TotalErros { get => totalErros; set => totalErros = value; }
    }
}
