﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModeloCanonico
{
    class RetornoPotabilidade
    {

     string motivo;

        public string Motivo
        {
            get { return motivo; }
            set { motivo = value; }
        }

        DateTime dataErro;

        public DateTime DataErro
        {
            get { return dataErro; }
            set { dataErro = value; }
        }


        string codigoErro;

        public string CodigoErro
        {
            get { return codigoErro; }
            set { codigoErro = value; }
        }

    }
}