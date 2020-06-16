using System;
using System.Runtime.Serialization;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class SondaFacturaDetalle : ISondaFacturaDetalle
    {
        
        public int INVOICE_ID { get; set; }

        public string INVOICE_SERIAL { get; set; }

        public string SKU { get; set; }

        public int LINE_SEQ { get; set; }

        public decimal? QTY { get; set; }

        public decimal? PRICE { get; set; }

        public decimal? DISCOUNT { get; set; }

        public decimal? TOTAL_LINE { get; set; }

        public DateTime? POSTED_DATETIME { get; set; }

        public string SERIE { get; set; }

        public string SERIE_2 { get; set; }

        public int? REQUERIES_SERIE { get; set; }

        public string COMBO_REFERENCE { get; set; }

        public string INVOICE_RESOLUTION { get; set; }

        public int? PARENT_SEQ { get; set; }

        public int? IS_ACTIVE_ROUTE { get; set; }
        public string TAX_ID { get; set; }


    }
}