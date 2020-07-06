using System;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class ConsignacionHistorica
    {
        public int CONSIGNMENT_ID { get; set; }

        public string CODE_CUSTOMER { get; set; }

        public string NAME_CUSTOMER { get; set; }

        public string DOC_SERIE { get; set; }

        public int DOC_NUM { get; set; }

        public string CODE_ROUTE { get; set; }

        public string NAME_ROUTE { get; set; }

        public string LOGIN { get; set; }

        public string NAME_USER { get; set; }

        public decimal TOTAL_AMOUNT { get; set; }

        public DateTime? DATE_CREATE { get; set; }

        public string CODE_SKU { get; set; }

        public string DESCRIPTION_SKU { get; set; }

        public int QTY { get; set; }

        public decimal PRICE { get; set; }

        public decimal TOTAL_LINE { get; set; }

        public string VALIDITY { get; set; }

        public string STATUS { get; set; }

        public string REASON { get; set; }

    }
}