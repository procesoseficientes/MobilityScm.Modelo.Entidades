using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class ReporteManifiestoEncabezado
    {
        public string LOGIN { get; set; }

        public string CODE_CUSTOMER { get; set; }

        public string NAME_CUSTOMER { get; set; }

        public string ADDRESS_CUSTOMER { get; set; }

        public float QTY { get; set; }

        public decimal TOTAL_AMOUNT { get; set; }

    }
}
