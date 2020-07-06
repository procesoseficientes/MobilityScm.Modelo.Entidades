using System;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class VistaConsignaciones
    {
        public int CONSIGNMENT_ID { get; set; }

        public string CUSTOMER_ID { get; set; }

        public DateTime DATE_CREATE { get; set; }

        public DateTime? DOC_DATE { get; set; }

        public DateTime? DUE_DATE { get; set; }

        public string STATUS { get; set; }

        public string GPS_URL { get; set; }

        public string SKU { get; set; }

        public string DESCRIPTION_SKU { get; set; }

        public decimal? PRICE { get; set; }

        public int? QTY { get; set; }

        public decimal? TOTAL_LINE { get; set; }

        public int? SKU_TOTAL { get; set; }

    }
}