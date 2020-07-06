using System;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class OrdenDeVentaDetalle
    {
        public int CORRELATIVE { get; set; }
        public int SALES_ORDER_ID { get; set; }

        public string SKU { get; set; }

        public string DESCRIPTION_SKU { get; set; }

        public int LINE_SEQ { get; set; }

        public decimal QTY { get; set; }

        public decimal PRICE { get; set; }

        public decimal DISCOUNT { get; set; }

        public decimal TOTAL_LINE { get; set; }

        public DateTime POSTED_DATETIME { get; set; }

        public string SERIE { get; set; }

        public string SERIE_2 { get; set; }

        public int REQUERIES_SERIE { get; set; }

        public string COMBO_REFERENCE { get; set; }

        public int PARENT_SEQ { get; set; }

        public int IS_ACTIVE_ROUTE { get; set; }

        public string SKU_DESCRIPTION { get; set; }

        public decimal TOTAL_DISCOUNT { get; set; }

        public string CODE_PACK_UNIT { get; set; }

        public string DESCRIPTION_PACK_UNIT { get; set; }


        public string CODE_ROUTE { get; set; }
        public string NAME_ROUTE { get; set; }
        public string LOGIN { get; set; }
        public string NAME_USER { get; set; }
        public string DOC_SERIE { get; set; }
        public int DOC_NUM { get; set; }
        public string SALES_ORDER_TYPE { get; set; }
        public decimal TOTAL_CD { get; set; }
        public string CODE_CUSTOMER { get; set; }
        public string NAME_CUSTOMER { get; set; }
        public DateTime STAR_DATE { get; set; }
        public DateTime END_DATE { get; set; }
        public decimal TOTAL_AMOUNT { get; set; }
        public decimal LONG { get; set; }

        public string CODE_WAREHOUSE { get; set; }
        public string NAME_WAREHOUSE { get; set; }
        public string COMMENT { get; set; }
        public int AVAILABLE_QTY { get; set; }

        public string WAREHOUSE { get; set; }
        public string CODE_OPER { get; set; }
        public string POS_TERMINAL { get; set; }
        public string CODE_SELLER { get; set; }
    }
}