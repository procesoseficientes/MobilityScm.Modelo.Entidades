using System;

namespace MobilityScm.Modelo.Entidades
{
    
    [Serializable]
    public class DevolucionDeInventario
    {
        public int DEVOLUTION_ID { get; set; }

        public string CODE_SKU { get; set; }

        public string DESCRIPTION_SKU { get; set; }

        public int QTY_SKU { get; set; }

        public int? IS_GOOD_STATE { get; set; }

        public DateTime? POSTED_DATETIME { get; set; }

        public string POSTED_BY { get; set; }

        public DateTime? LAST_UPDATE { get; set; }

        public string LAST_UPDATE_BY { get; set; }



        public string SOURCE_DOC_TYPE { get; set; }

        public int? SOURCE_DOC_NUM { get; set; }

        public string CODE_ROUTE { get; set; }

        public string NAME_ROUTE { get; set; }

        public string NAME_USER { get; set; }

        public string CODE_CUSTOMER { get; set; }

        public string NAME_CUSTOMER { get; set; }

        public string DOC_SERIE { get; set; }

        public int DOC_NUM { get; set; }

        public string SOURCE_DOC_SERIE { get; set; }
        

        public decimal GOOD_STATE_QTY { get; set; }

        public decimal BAD_STATE_QTY { get; set; }

        public decimal TOTAL_QTY { get; set; }

        public decimal TOTAL_AMOUNT_IN_GOOD_STATE { get; set; }

        public decimal TOTAL_AMOUNT_IN_BAD_STATE { get; set; }

        public decimal TOTAL_AMOUNT { get; set; }

        public decimal PRICE { get; set; }

        public string SERIAL_NUMBER { get; set; }
    }
}