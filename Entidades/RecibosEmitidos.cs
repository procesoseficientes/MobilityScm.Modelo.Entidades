using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class RecibosEmitidos
    {
        public int ID { get; set; }

        public int DOC_NUM { get; set; }

        public string DOC_SERIE{ get; set; }

        public string CODE_CUSTOMER { get; set; }

        public string NAME_CUSTOMER { get; set; }

        public DateTime CREATED_DATE { get; set; }

        public Decimal PAYMENT_AMOUNT { get; set; }

        public string CODE_ROUTE { get; set; }

        public string CODE_SELLER { get; set; }

        public string NAME_USER { get; set; }
        public string USER { get; set; }

        public string STATE { get; set; }
        public DateTime POSTED_DATE { get; set; }
        public string SENDRESPONSE { get; set; }
        
    }
}
