using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace CancaoDoExilio
{
    public class Texto : ITexto
    {
        public int GerarTexto()
        {
            return Util.GerarTexto();
        }

        string ITexto.GerarTexto()
        {
            throw new NotImplementedException();
        }
    }
}
