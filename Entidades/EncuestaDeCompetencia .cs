using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class EncuestaDeCompetencia
    {
        public int BUSINESS_RIVAL_POLL { get; set; }

        public string INVOICE_RESOLUTION { get; set; }

        public string INVOICE_SERIE { get; set; }

        public int INVOICE_NUM { get; set; }

        public string CODE_CUSTOMER { get; set; }

        public string BUSSINESS_RIVAL_NAME { get; set; }

        public decimal BUSSINESS_RIVAL_TOTAL_AMOUNT { get; set; }

        public decimal CUSTOMER_TOTAL_AMOUNT { get; set; }

        public string COMMENT { get; set; }

        public int ROUTE { get; set; }

        public string CODE_ROUTE { get; set; }

        public DateTime POSTED_DATETIME { get; set; }

        public string NAME_CUSTOMER { get; set; }

        public string COLOR { get; set; }

    }
}
