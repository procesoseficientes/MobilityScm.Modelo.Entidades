using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class ConsignacionDetalle
    {
        public int CONSIGNMENT_ID { get; set; }

        public DateTime DATE_CREATE { get; set; }

        public string CUSTOMER_ID { get; set; }

        public string NAME_CUSTOMER { get; set; }

        public string ADDRESS_CUSTOMER { get; set; }

        public string CODE_ROUTE { get; set; }

        public string NAME_ROUTE { get; set; }

        public decimal?TOTAL_AMOUNT { get; set; }

        public int REST_DAYS { get; set; }

        public DateTime? DUE_DATE { get; set; }

        public string STATUS { get; set; }

        public string SKU { get; set; }

        public string DESCRIPTION_SKU { get; set; }

        public int QTY { get; set; }

        public decimal? PRICE { get; set; }

        public decimal TOTAL_LINE { get; set; }

        public int ELAPSED_DAYS { get; set; }

        public string LATITUDE { get; set; }

        public string LONGITUDE { get; set; }

        //-------------------------------
        
        public int LINE_NUM { get; set; }

        public decimal? DISCOUNT { get; set; }
        
        public DateTime POSTED_DATETIME { get; set; }
        
        public int COUNT { get; set; }

        public int PAYMENT_ID { get; set; }

        public string VOID_STATUS { get; set; }

        public string REASON { get; set; }

        public string SERIAL_NUMBER { get; set; }
    }
}
