using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class TransferenciaDetalle
    {
        public decimal TRANSFER_ID { get; set; }

        public string SKU_CODE { get; set; }

        public string DESCRIPTION_SKU { get; set; }

        public float QTY { get; set; }

        public string SERIE { get; set; }

        public string CODE_WAREHOUSE_SOURCE { get; set; }

        public string SALES_PACK_UNIT { get; set; }

        public string CODE_PACK_UNIT_STOCK { get; set; }

        public string VAT_CODE { get; set; }
    }
}
