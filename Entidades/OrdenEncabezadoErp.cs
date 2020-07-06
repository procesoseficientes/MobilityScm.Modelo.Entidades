using System;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class OrdenEncabezadoErp
    {
        public int SAP_REFERENCE { get; set; }

        public string DOC_TYPE { get; set; }

        public string DESCRIPTION_TYPE { get; set; }

        public string CUSTOMER_ID { get; set; }

        public string CUSTOMER_NAME { get; set; }

        public string COD_WAREHOUSE { get; set; }

        public string WAREHOUSE_NAME { get; set; }

        public string CODE_OPER { get; set; }

        public string CODE_ROUTE { get; set; }

        public string NAME_ROUTE { get; set; }

        public string SELLER_CODE { get; set; }

        public string SELLER_NAME { get; set; }
    }
}
