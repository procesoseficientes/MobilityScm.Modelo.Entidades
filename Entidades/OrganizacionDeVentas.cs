using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class OrganizacionDeVentas
    {
        public int? SALES_ORGANIZATION_ID { get; set; }

        public string NAME_SALES_ORGANIZATION { get; set; }

        public string DESCRIPTION_SALES_ORGANIZATION { get; set; }

    }

}
