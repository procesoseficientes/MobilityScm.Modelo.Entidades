using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class SwiftNotaDeCreditoDetalle
    {
        public int ERP_RECEPTION_DOCUMENT_HEADER_ID { get; set; }
        public string MATERIAL_ID { get; set; }
        public string MATERIAL_NAME { get; set; }
        public decimal QTY { get; set; }
        public int LINE_NUM { get; set; }
        public int DOC_ENTRY { get; set; }
        public string TAX_CODE { get; set; }
        public decimal VAT_PERCENT { get; set; }
        public decimal PRICE { get; set; }
        public decimal DISCOUNT { get; set; }
        public string WAREHOUSE_CODE { get; set; }
        public string CURRENCY { get; set; }
        public decimal RATE { get; set; }
        public string COST_CENTER { get; set; }
        public int AgrNo { get; set; }
    }
}
