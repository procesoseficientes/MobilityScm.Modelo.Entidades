using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class OrdenDetalleErp
    {

        public string SAP_PICKING_ID { get; set; }

        public int ERP_DOC { get; set; }

        public string CUSTOMER_ID { get; set; }

        public string CUSTOMER_NAME { get; set; }

        public string SKU { get; set; }

        public string SKU_DESCRIPTION { get; set; }

        public float QTY { get; set; }

        public float QTY_SOURCE { get; set; }

        public string SHIPPING_TO { get; set; }

        public string SELLER_NAME { get; set; }

        public string COMMENTS { get; set; }

        public string TARGET_WAREHOUSE { get; set; }

        public string SORUCE_WAREHOUSE { get; set; }

        public string DOC_TYPE { get; set; }

        public string DESCRIPTION_TYPE { get; set; }

        public string CODE_OPER { get; set; }

        public float DIFFERENCE { get; set; }

        public float TO_SALE { get; set; }

        public string CODE_SELLER { get; set; }

        public string CODE_ROUTE { get; set; }
    }
}
