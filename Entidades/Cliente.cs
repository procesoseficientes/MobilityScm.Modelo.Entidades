using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using MobilityScm.Utilerias;
using Telerik.OpenAccess.Data.Common;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class Cliente : ICliente
    {

        public int CUSTOMER { get; set; }

        public string CODE_CUSTOMER { get; set; }

        public string NAME_CUSTOMER { get; set; }

        public string PHONE_CUSTOMER { get; set; }

        public string ADRESS_CUSTOMER { get; set; }

        public string CLASSIFICATION_CUSTOMER { get; set; }

        public string CONTACT_CUSTOMER { get; set; }

        public string CODE_ROUTE { get; set; }

        public DateTime? LAST_UPDATE { get; set; }

        public string LAST_UPDATE_BY { get; set; }

        public string SELLER_DEFAULT_CODE { get; set; }

        public float? CREDIT_LIMIT { get; set; }

        public string SIGN { get; set; }

        public string PHOTO { get; set; }

        public string STATUS { get; set; }

        public int? NEW { get; set; }

        public string GPS { get; set; }

        public string CODE_CUSTOMER_HH { get; set; }

        public string REFERENCE { get; set; }

        public DateTime? POST_DATETIME { get; set; }

        public string POS_SALE_NAME { get; set; }

        public string INVOICE_NAME { get; set; }

        public string INVOICE_ADDRESS { get; set; }

        public string NIT { get; set; }

        public string CONTACT_ID { get; set; }

        public string COMMENTS { get; set; }

        public int? ATTEMPTED_WITH_ERROR { get; set; }

        public int? IS_POSTED_ERP { get; set; }

        public DateTime? POSTED_ERP { get; set; }

        public string POSTED_RESPONSE { get; set; }
        public string SALES_PERSON_CODE { get; set; }

        public string LATITUDE { get; set; }
        public string LONGITUDE { get; set; }

        public string FREQUENCY_WEEKS { get; set; }
        public string MONDAY { get; set; }
        public string TUESDAY { get; set; }
        public string WEDNESDAY { get; set; }
        public string THURSDAY { get; set; }
        public string FRIDAY { get; set; }
        public string SATURDAY { get; set; }
        public string SUNDAY { get; set; }

        public string DEPARTAMENT { get; set; }

        public string MUNICIPALITY { get; set; }

        public string COLONY { get; set; }

        public int? UPDATED_FROM_BO { get; set; }

        public string SYNC_ID { get; set; }

        public int IS_NEW { get; set; }

        public string CODE_CUSTOMER_BO { get; set; }

        public string FIELD_NAME_FOR_TAX_ID { get; set; }
        public int CREATE_NEW_CUSTOMER_AS_LID { get; set; }
        public int? DEFAULT_GROUP_CODE { get; set; }

        public int OWNER_ID { get; set; }

        public string IS_FROM { get; set; }

    }
}
