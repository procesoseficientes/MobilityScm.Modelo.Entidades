using System;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class ConsignacionTransaccion
    {        
        public int HISTORICAL_ID { get; set; }

        public int? CONSIGNMENT_ID { get; set; }

        public string DOC_SERIE { get; set; }

        public int? DOC_NUM { get; set; }

        public string CODE_SKU { get; set; }

        public int? QTY_SKU { get; set; }

        public string ACTION { get; set; }

        public string DOC_SERIE_TARGET { get; set; }

        public int? DOC_NUM_TARGET { get; set; }

        public DateTime? DATE_TRANSACTION { get; set; }

        public DateTime? POSTED_DATETIME { get; set; }

        public string POSTED_BY { get; set; }

        public int? IS_POSTED { get; set; }

        public string DESCRIPTION_SKU { get; set; }

        public string SERIAL_NUMBER { get; set; }

    }
}
