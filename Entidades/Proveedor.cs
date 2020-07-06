using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
   public class Proveedor
    {
        public string CODE_PROVIDER { get; set; }

        public string NAME_PROVIDER { get; set; }

        public string CODE_SKU { get; set; }

        public string DESCRIPTION_SKU { get; set; }

        public string BATCH_ID { get; set; }

        public DateTime? BATCH_SUPPLIER_EXPIRATION_DATE { get; set; }

        public int? PALLET_ID { get; set; }

        public float? ON_HAND { get; set; }


    }
}
