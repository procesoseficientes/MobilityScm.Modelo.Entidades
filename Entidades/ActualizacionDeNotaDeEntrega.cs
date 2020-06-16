using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    public class ActualizacionDeNotaDeEntrega
    {
        public int PICKING_DEMAND_HEADER_ID { get; set; }
        public string PLATE_NUMBER { get; set; }
        public string ERP_REFERENCE { get; set; } 
        public string ERP_REFERENCE_DOC_NUM { get; set; }
    }
}
