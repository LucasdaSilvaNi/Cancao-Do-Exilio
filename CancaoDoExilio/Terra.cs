using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CancaoDoExilio
{
    public class Terra
    {
        public int QuantidadePalmeirasAvistadas = 7;

        public string sabiaCanta = "Sim";

        protected Palmeira[] palmeiras;

        public List<Ave> aves;

        public bool Terminou
        {
            get
            {
                return Terminou;
            }
            set
            {
                Terminou = value;
            }
        }


        public double ObterQuantidadeCoisas()
        {
            double teste = 1.5;
            for (int i = 0; i < 20; i++)
            {
                teste = teste + 1.54;
            }

            return teste;
        }

        public bool ObterPrimores()
        {
            int x = 20;
            int y = 10;

            return y == 20 && x == 10;
        }
    }
}
