using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CancaoDoExilio
{
    public class Ave : Animal
    {
        public string TipoAsas
        {
            get;
            set;
        }

        private int gorjeio = 1;
        private string nome;

        public void AlterarNome(string nome)
        {
            this.nome = nome;
        }

        public void AlterarTipoAsas(string tipoAsas)
        {
            this.TipoAsas = tipoAsas;
        }

        public int ObterGojeio()
        {
            return 100 / gorjeio;
        }
    }
}