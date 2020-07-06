using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class FacturaDetalle
    {
        public int INVOICE_ID { get; set; }

        public string INVOICE_SERIAL { get; set; }

        public string SKU { get; set; }

        public int LINE_SEQ { get; set; }

        public decimal QTY { get; set; }

        public decimal PRICE { get; set; }

        public decimal DISCOUNT { get; set; }

        public decimal TOTAL_LINE { get; set; }

        public decimal CREDIT_AMOUNT { get; set; }

        public decimal CASH_AMOUNT { get; set; }

        public string INVOICE_TYPE { get; set; }

        public DateTime POSTED_DATETIME { get; set; }

        public string SERIE { get; set; }

        public string SERIE_2 { get; set; }

        public int REQUERIES_SERIE { get; set; }

        public string COMBO_REFERENCE { get; set; }

        public string INVOICE_RESOLUTION { get; set; }

        public int PARENT_SEQ { get; set; }

        public int IS_ACTIVE_ROUTE { get; set; }

        public string SKU_DESCRIPTION { get; set; }

        public string CODE_ROUTE { get; set; }

        public string NAME_ROUTE { get; set; }

        public string LOGIN { get; set; }

        public string NAME_USER { get; set; }

        public string CDF_RESOLUCION { get; set; }

        public string CDF_SERIE { get; set; }

        public string STATUS { get; set; }

        public string CLIENT_ID { get; set; }

        public string CDF_NOMBRECLIENTE { get; set; }

        public string CDF_NIT { get; set; }

        public int VOIDED_INVOICE { get; set; }

        public string VOID_REASON { get; set; }

        public DateTime VOID_DATETIME { get; set; }

        public string GPS_EXPECTED { get; set; }

        public string GPS_URL { get; set; }

        public decimal TOTAL_AMOUNT { get; set; }
        public int IS_CREDIT_NOTE { get; set; }

        public string LATITUDE_EXPECTED { get; set; }

        public string LONGITUDE_EXPECTED { get; set; }

        public string LATITUDE { get; set; }

        public string LONGITUDE { get; set; }
        public float GPS_DISTANCE { get; set; }

        public string DESCRIPTION_SKU { get; set; }

        public string TELEPHONE_NUMBER { get; set; }

        public string CODE_CUSTOMER_ALTERNATE { get; set; }

        public string PAY_DEAL { get; set; }

        public string SERIAL_NR { get; set; }

        public string ART_CODE { get; set; }

        public string VAT_CODE { get; set; }

        public int ID { get; set; }

        public int IS_EXPORTED_TO_XML { get; set; }
        public string COMMENT { get; set; }


        public string IS_EXPORTED_TO_XML_DESCRIPTION { get; set; }

    }
}
