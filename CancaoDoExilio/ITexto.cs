﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CancaoDoExilio
{
    public interface ITexto
    {
        public bool TextoGerado;

        string GerarTexto();
    }
}