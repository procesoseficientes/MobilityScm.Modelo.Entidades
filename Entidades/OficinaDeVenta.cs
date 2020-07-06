using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class OficinaDeVenta
    {
        public int? SALES_OFFICE_ID { get; set; }

        public int? SALES_ORGANIZATION_ID { get; set; }

        public string NAME_SALES_OFFICE { get; set; }

        public string DESCRIPTION_SALES_OFFICE { get; set; }

        public string NAME_SALES_ORGANIZATION { get; set; }

        public string DESCRIPTION_SALES_ORGANIZATION { get; set; }
    }
}
