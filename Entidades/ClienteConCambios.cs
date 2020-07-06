using System;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class ClienteConCambios
    {
        public int CUSTOMER { get; set; }

        public string CODE_CUSTOMER { get; set; }

        public string PHONE_CUSTOMER { get; set; }

        public string ADRESS_CUSTOMER { get; set; }

        public string CONTACT_CUSTOMER { get; set; }

        public string GPS { get; set; }

        public DateTime POSTED_DATETIME { get; set; }

        public string POSTED_BY { get; set; }

        public string CODE_ROUTE { get; set; }

        public string STATUS { get; set; }

        public string STATUS_CHANGE_BY { get; set; }

        public DateTime STATUS_CHANGE_DATETIME { get; set; }

        public int ATTEMPTED_WITH_ERROR { get; set; }

        public int IS_POSTED_ERP { get; set; }

        public DateTime POSTED_ERP { get; set; }

        public string POSTED_RESPONSE { get; set; }

        public DateTime LAST_UPDATE { get; set; }

        public string LAST_UPDATE_BY { get; set; }

        public string TAX_ID { get; set; }

        public string INVOICE_NAME { get; set; }

        public string CUSTOMER_NAME { get; set; }

        public string NEW_CUSTOMER_NAME { get; set; }
    }
}
