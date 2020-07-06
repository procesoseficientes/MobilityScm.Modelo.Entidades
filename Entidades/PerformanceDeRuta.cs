using System;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class PerformanceDeRuta
    {
        public int? TASK_ID { get; set; }

        public string COSTUMER_CODE { get; set; }

        public string COSTUMER_NAME { get; set; }

        public DateTime? SCHEDULE_FOR { get; set; }

        public string EXPECTED_GPS { get; set; }

        public string POSTED_GPS { get; set; }

        public float? DISTANCE { get; set; }

        public string KPI { get; set; }

        public DateTime? ACCEPTED_STAMP { get; set; }

        public DateTime? COMPLETED_STAMP { get; set; }

        public TimeSpan? ELAPSED_TIME { get; set; }

        public string TASK_STATUS { get; set; }

        public string SELLER_ROUTE { get; set; }

        public string NOSALES_REASON { get; set; }

        public int? SALES_ORDER_ID { get; set; }

        public DateTime? SALES_ORDER_DATE { get; set; }

        public string DOC_SERIE { get; set; }

        public int? DOC_NUM { get; set; }

        public decimal? TOTAL_AMOUNT { get; set; }

        public decimal? DISCOUNT { get; set; }

        public decimal? DISCOUNT_AMOUNT { get; set; }

        public decimal? TOTAL_CD { get; set; }

        public string SKU { get; set; }

        public string DESCRIPTION_SKU { get; set; }

        public string CODE_FAMILY_SKU { get; set; }

        public string DESCRIPTION_FAMILY_SKU { get; set; }

        public int? QTY { get; set; }

        public decimal? PRICE { get; set; }

        public decimal? TOTAL_LINE { get; set; }

        public decimal? DISCOUNT_LINE { get; set; }

        public decimal? TOTAL_LINE_CD { get; set; }

        public int DEFAULT_DISPLAY_DECIMALS { get; set; }

    }
}
