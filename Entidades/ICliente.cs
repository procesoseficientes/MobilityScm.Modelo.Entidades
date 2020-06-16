using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
   public interface ICliente
    {
       int CUSTOMER { get; set; }

        string CODE_CUSTOMER { get; set; }

        string NAME_CUSTOMER { get; set; }

        string PHONE_CUSTOMER { get; set; }

        string ADRESS_CUSTOMER { get; set; }

        string CLASSIFICATION_CUSTOMER { get; set; }

        string CONTACT_CUSTOMER { get; set; }

        string CODE_ROUTE { get; set; }

        DateTime? LAST_UPDATE { get; set; }

        string LAST_UPDATE_BY { get; set; }

        string SELLER_DEFAULT_CODE { get; set; }

        float? CREDIT_LIMIT { get; set; }

        string SIGN { get; set; }

        string PHOTO { get; set; }

        string STATUS { get; set; }

        int? NEW { get; set; }

        string GPS { get; set; }

        string CODE_CUSTOMER_HH { get; set; }

        string REFERENCE { get; set; }

        DateTime? POST_DATETIME { get; set; }

        string POS_SALE_NAME { get; set; }

        string INVOICE_NAME { get; set; }

        string INVOICE_ADDRESS { get; set; }

        string NIT { get; set; }

        string CONTACT_ID { get; set; }

        string COMMENTS { get; set; }

        int? ATTEMPTED_WITH_ERROR { get; set; }

        int? IS_POSTED_ERP { get; set; }

        DateTime? POSTED_ERP { get; set; }

        string POSTED_RESPONSE { get; set; }

        string SALES_PERSON_CODE { get; set; }

        string LATITUDE { get; set; }
        string LONGITUDE { get; set; }

        string FREQUENCY_WEEKS { get; set; }
        string MONDAY { get; set; }
        string TUESDAY { get; set; }
        string WEDNESDAY { get; set; }
        string THURSDAY { get; set; }
        string FRIDAY { get; set; }
        string SATURDAY { get; set; }
        string SUNDAY { get; set; }

        string DEPARTAMENT { get; set; }
        string MUNICIPALITY { get; set; }
        string COLONY { get; set; }
    }
}
