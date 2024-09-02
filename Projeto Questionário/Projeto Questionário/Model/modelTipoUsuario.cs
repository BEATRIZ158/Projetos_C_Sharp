using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Projeto_Questionário.Model
{
    internal class modelTipoUsuario
    {
        private int idTipo;
        private string nomeTipo;

        // Criando métodos públicos para acessar os atributos da classe modelTipoUsuario, pois são privados

        public int IdTipo { get => idTipo; set => idTipo = value; }
        public string NomeTipo { get => nomeTipo; set => nomeTipo = value; }
    }
}
