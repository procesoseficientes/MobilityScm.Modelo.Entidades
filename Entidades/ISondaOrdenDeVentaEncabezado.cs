using System;

namespace MobilityScm.Modelo.Entidades
{
    public interface ISondaOrdenDeVentaEncabezado
    {
        int SALES_ORDER_ID { get; set; }
        string TERMS { get; set; }
        DateTime? POSTED_DATETIME { get; set; }
        string CLIENT_ID { get; set; }
        string POS_TERMINAL { get; set; }
        string GPS_URL { get; set; }
        decimal? TOTAL_AMOUNT { get; set; }
        int? STATUS { get; set; }
        string POSTED_BY { get; set; }
        string IMAGE_1 { get; set; }
        string IMAGE_2 { get; set; }
        string IMAGE_3 { get; set; }
        int? DEVICE_BATTERY_FACTOR { get; set; }
        DateTime? VOID_DATETIME { get; set; }
        string VOID_REASON { get; set; }
        string VOID_NOTES { get; set; }
        int? VOIDED { get; set; }
        DateTime? CLOSED_ROUTE_DATETIME { get; set; }
        int? IS_ACTIVE_ROUTE { get; set; }
        string GPS_EXPECTED { get; set; }
        DateTime? DELIVERY_DATE { get; set; }
        int? SALES_ORDER_ID_HH { get; set; }
        int? ATTEMPTED_WITH_ERROR { get; set; }
        int? IS_POSTED_ERP { get; set; }
        DateTime? POSTED_ERP { get; set; }
        string POSTED_RESPONSE { get; set; }
        string NAME_CUSTOMER { get; set; }
        string TAX_ID_NUMBER { get; set; }
        string ADRESS_CUSTOMER { get; set; }
        string SALES_PERSON_CODE { get; set; }
        string SALES_ORDER_TYPE { get; set; }

        string OFIVENTAS { get; set; }
        string RUTAVENTAS { get; set; }
        string RUTAENTREGA { get; set; }
        string NUM_AT_CARD { get; set; }

        string SONDA { get; set; }

        string COMMENT { get; set; }

        string OWNER { get; set; }
        string INTERFACE_OWNER { get; set; }
        string CLIENT_OWNER { get; set; }

    }
}