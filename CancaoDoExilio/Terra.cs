using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CancaoDoExilio
{
    public class Terra
    {
        public int QuantidadePalmeirasAvistadas = 1;

        public bool sabiaCanta = true;

        public Palmeira[] palmeiras;

        public List<Ave> aves;

        public Terra() {
            palmeiras = new Palmeira[2];
            aves = new List<Ave>();
            aves.Add(new Ave());
        }

        private bool terminou;

        public bool Terminou
        {
            get
            {
                return terminou;
            }
            set
            {
                terminou = value;
            }
        }


        public double ObterQuantidadeCoisas()
        {
            double teste = 1.5;
            for (int i = 0; i < 20; i++)
            {
                teste = teste + 1.54;
            }

            return Math.Floor(teste);
        }

        public bool ObterPrimores()
        {
            int x = 20;
            int y = 10;

            return y == 20 && x == 10;
        }
    }
}
