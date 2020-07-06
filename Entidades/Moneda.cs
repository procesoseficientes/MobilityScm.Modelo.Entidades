using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class Moneda
    {
        public int CURRENCY_ID { get; set; }

        public string CODE_CURRENCY { get; set; }

        public string NAME_CURRENCY { get; set; }

        public string SYMBOL_CURRENCY { get; set; }

        public int IS_DEFAULT { get; set; }

        public string IS_DEFAULT_DESCRIPTION { get; set; }
    }
}
