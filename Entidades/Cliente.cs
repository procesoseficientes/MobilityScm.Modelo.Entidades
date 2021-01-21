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
    public class Cliente
    {
        public int? CUSTOMER { get; set; }

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

        public int FROM_ERP { get; set; }

        public string TAX_ID_NUMBER { get; set; }

        public string SIGN { get; set; }

        public string PHOTO { get; set; }

        public string STATUS { get; set; }

        public int? NEW { get; set; }
        public string GPS { get; set; }
        public string CODE_CUSTOMER_HH { get; set; }

        public string FREQUENCY { get; set; }

        public string TAGS { get; set; }

        public string LATITUDE { get; set; }

        public string LONGITUDE { get; set; }

        public string Tags { get; set; }

        public int NotTags { get; set; }

        public string REFERENCE { get; set; }

        public string NAME_ROUTE { get; set; }

        public DateTime FechaIncio { get; set; }

        public DateTime FechaFinal { get; set; }
        public DateTime? POST_DATETIME { get; set; }

        public int ID_FREQUENCY { get; set; }

        public int PRIORITY { get; set; }

        public string POS_SALE_NAME { get; set; }

        public string INVOICE_NAME { get; set; }

        public string INVOICE_ADDRESS { get; set; }

        public string NIT { get; set; }

        public string CONTACT_ID { get; set; }

        public string COMMENTS { get; set; }

        public string STATUS_NEW { get; set; }

        public string LOGIN { get; set; }

        public int EXTRA_DAYS { get; set; }

        public decimal DISCOUNT { get; set; }

        public string CODE_PRICE_LIST { get; set; }

        public int? ATTEMPTED_WITH_ERROR { get; set; }

        public int? IS_POSTED_ERP { get; set; }

        public string IS_POSTED_ERP_DESCRIPTION { get; set; }

        public DateTime? POSTED_ERP { get; set; }

        public string POSTED_RESPONSE { get; set; }
        public string SALES_PERSON_CODE { get; set; }

        public DateTime DATE_START { get; set; }

        public DateTime DATE_END { get; set; }

        public string DEPARTAMENT { get; set; }

        public string MUNICIPALITY { get; set; }

        public string COLONY { get; set; }

        public int? UPDATED_FROM_BO { get; set; }
        public string SYNC_ID { get; set; }

        public Frecuencia Frecuencia { get; set; }

        public int CODE_FREQUENCY { get; set; }

        public int SUNDAY { get; set; }

        public int MONDAY { get; set; }

        public int TUESDAY { get; set; }

        public int WEDNESDAY { get; set; }

        public int THURSDAY { get; set; }

        public int FRIDAY { get; set; }

        public int SATURDAY { get; set; }

        public int DAY { get; set; }
        public int FREQUENCY_WEEKS { get; set; }

        public DateTime LAST_DATE_VISITED { get; set; }

        public int HAS_FREQUENCY { get; set; }

        public DateTime LAST_OPTIMIZATION { get; set; }

        public int TRADE_AGREEMENT_ID { get; set; }

        public string SELLER_NAME { get; set; }
        public string TYPE_TASK { get; set; }

        public string NAME_CHANNEL{ get; set; }

        public string ASOCIADO { get; set; }

        /// <summary>
        /// Tiene propuesta de frecuencia
        /// </summary>
        public int HAS_PROPOSAL { get; set; }

        /// <summary>
        /// Es nuevo dentro de un poligono. 
        /// </summary>
        public int IS_NEW { get; set; }

        public string CODE_CHANNEL { get; set; }

        public int POLYGON_ID { get; set; }

        public string CODE_CUSTOMER_BO { get; set; }
        public string FIELD_NAME_FOR_TAX_ID { get; set; }
        public int CREATE_NEW_CUSTOMER_AS_LID { get; set; }
        public int? DEFAULT_GROUP_CODE { get; set; }

        public string SCOUTING_ROUTE { get; set; }

        public int OWNER_ID { get; set; }

        public string OWNER_NAME { get; set; }

        public string NAME_USER { get; set; }

        public string PHOTO_2 { get; set; }

        public string PHOTO_3 { get; set; }

        public string PHOTO_4 { get; set; }

        public string IS_FROM { get; set; }

        public string JSON { get; set; }

        public string DOC_SERIE { get; set; }

        public int DOC_NUM { get; set; }

        public string POSTED_BY { get; set; }

        public int IS_READY_TO_SEND { get; set; }

        public int IS_SENDING { get; set; }

        public DateTime LAST_UPDATE_IS_SENDING { get; set; }
    }
}