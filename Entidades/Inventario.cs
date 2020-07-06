using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class Inventario
    {
        public int INVENTORY { get; set; }

        public string SERIAL_NUMBER { get; set; }

        public string WAREHOUSE { get; set; }

        public string LOCATION { get; set; }

        public string SKU { get; set; }

        public string SKU_DESCRIPTION { get; set; }

        public float? ON_HAND { get; set; }

        public string BATCH_ID { get; set; }

        public DateTime? LAST_UPDATE { get; set; }

        public string LAST_UPDATE_BY { get; set; }

        public int? TXN_ID { get; set; }

        public int? IS_SCANNED { get; set; }

        public DateTime? RELOCATED_DATE { get; set; }

        public DateTime? START_DATE { get; set; }

        public DateTime? END_DATE { get; set; }

        public int RELOCATED_DAYS { get; set; }

        public string WAREHOUSE_TARGED { get; set; }
        
        public string LOCATION_TARGED { get; set; }

        public float? QTY { get; set; }

        public string SKUS { get; set; }

        public string QTYS { get; set; }

        public float REQUEST_QTY { get; set; }

        public float DIFFERENCE { get; set; }

        public float TO_SALE { get; set; }

        public string CODE_SKU { get; set; }

        public int? PALLET_ID { get; set; }

        public string DESCRIPTION_WAREHOUSE { get; set; }
    }
}
