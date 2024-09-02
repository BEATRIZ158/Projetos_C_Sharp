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
        private int totalAcerto;
        private DateTime dataTentativa;

        public int IdTentativa { get => idTentativa; set => idTentativa = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int TotalAcerto { get => totalAcerto; set => totalAcerto = value; }
        public DateTime DataTentativa { get => dataTentativa; set => dataTentativa = value; }
    }
}
