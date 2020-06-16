using System;

namespace MobilityScm.Modelo.Entidades
{
    public interface ICambiosCliente
    {
        string ADRESS_CUSTOMER { get; set; }
        int? ATTEMPTED_WITH_ERROR { get; set; }
        string CODE_CUSTOMER { get; set; }
        string CODE_ROUTE { get; set; }
        string CONTACT_CUSTOMER { get; set; }
        int CUSTOMER { get; set; }
        string GPS { get; set; }
        int? IS_POSTED_ERP { get; set; }
        DateTime? LAST_UPDATE { get; set; }
        string LAST_UPDATE_BY { get; set; }
        string PHONE_CUSTOMER { get; set; }
        string POSTED_BY { get; set; }
        DateTime POSTED_DATETIME { get; set; }
        DateTime? POSTED_ERP { get; set; }
        string POSTED_RESPONSE { get; set; }
        string STATUS { get; set; }
        string STATUS_CHANGE_BY { get; set; }
        DateTime? STATUS_CHANGE_DATETIME { get; set; }
        string NEW_CUSTOMER_NAME { get; set; }
        string DEPARTMENT { get; set; }
        string MUNICIPALITY { get; set; }
        string COLONY { get; set; }
    }
}