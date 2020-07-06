using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class ClienteDetalle
    {
        public int CUSTOMER { get; set; }

        public string SALE_ROUTE { get; set; }

        public string REFERENCE_CBC { get; set; }

        public string VISIT_DAY { get; set; }

        public string VISIT_FRECUENCY { get; set; }

        public decimal? TIME_DELIVER_DAYS { get; set; }

        public string BRANCH { get; set; }

        public string SERVICE_WINDOW { get; set; }

        public string SALE_POINT_COMPLEMENT_DIRECTION { get; set; }

        public string INVOICE_ADRESS_COMPLEMENT { get; set; }

        public string MUNICIPALITY { get; set; }

        public string DEPARTMENT { get; set; }

        public decimal? CREDIT_LIMIT { get; set; }

        public string CODE_BUSINESS_GYRE { get; set; }

        public string BUSINESS_GYRE_DENOMINATION { get; set; }

        public string CREDIT_CONTROL_AREA { get; set; }

        public string FORM_PAY_AUTHORIZATION { get; set; }

        public string CURRENCY { get; set; }

        public string ASSOCIATED_ACCOUNTANT_CREDIT_COUNT { get; set; }

        public string PAY_CONDITION { get; set; }

        public string CREDIT_BLOCKADE { get; set; }

        public string LAST_UPDATED_BY { get; set; }

        public string COMMENTS { get; set; }

    }
}
