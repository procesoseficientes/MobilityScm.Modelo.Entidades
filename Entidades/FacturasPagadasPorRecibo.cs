using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{   
    [Serializable]
    public class FacturasPagadasPorRecibo
    {
        public int INVOICE_ID { get; set; }

        public DateTime POSTED_DATE { get; set; }

        public DateTime CREATED_DATE { get; set; }

        public Decimal TOTAL_AMOUNT { get; set; }

        public Decimal AMOUNT_PAYED { get; set; }

        public Decimal PENDING_TO_PAID { get; set; }
    }
}
