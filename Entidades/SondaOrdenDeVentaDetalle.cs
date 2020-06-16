using System;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class SondaOrdenDeVentaDetalle : ISondaOrdenDeVentaDetalle
    {
        
        public int SALES_ORDER_ID { get; set; }

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

        public int? PARENT_SEQ { get; set; }

        public int? IS_ACTIVE_ROUTE { get; set; }
        public string UM_CODE { get; set; }

        public double DISC_PRCNT { get; set; }

        public int UM_ENTRY { get; set; }

        public int IS_BONUS { get; set; }

        public string CODE_PACK_UNIT { get; set; }

        public decimal? LONG { get; set; }
        public string OWNER { get; set; }
    }
}