using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MobilityScm.Modelo.Entidades
{
    public interface ISondaFacturaEncabezado
    {
        int? ATTEMPTED_WITH_ERROR { get; set; }
        int? CDF_DOCENTRY { get; set; }
        int? CDF_INVOICENUM { get; set; }
        string CDF_NIT { get; set; }
        string CDF_NOMBRECLIENTE { get; set; }
        DateTime? CDF_POSTED_ERP { get; set; }
        int? CDF_PRINTED_COUNT { get; set; }
        string CDF_RESOLUCION { get; set; }
        string CDF_SERIE { get; set; }
        DateTime? CLEARING_DATETIME { get; set; }
        string CLIENT_ID { get; set; }
        DateTime? CLOSED_ROUTE_DATETIME { get; set; }
        int? DEVICE_BATTERY_FACTOR { get; set; }
        string GPS_EXPECTED { get; set; }
        string GPS_URL { get; set; }
        string IMAGE_1 { get; set; }
        string IMAGE_2 { get; set; }
        string IMAGE_3 { get; set; }
        DateTime? INVOICED_DATETIME { get; set; }
        int INVOICE_ID { get; set; }
        int? IS_ACTIVE_ROUTE { get; set; }
        int IS_CREDIT_NOTE { get; set; }
        int? IS_POSTED_ERP { get; set; }
        int? IS_POSTED_OFFLINE { get; set; }
        string POSTED_BY { get; set; }
        DateTime? POSTED_DATETIME { get; set; }
        DateTime? POSTED_ERP { get; set; }
        string POSTED_RESPONSE { get; set; }
        string POS_TERMINAL { get; set; }
        List<SondaFacturaDetalle> SondaFacturaDetalle { get; }
        decimal? SOURCE_CODE { get; set; }
        int? STATUS { get; set; }
        string TERMS { get; set; }
        decimal? TOTAL_AMOUNT { get; set; }
        int? VOIDED_INVOICE { get; set; }
        DateTime? VOID_DATETIME { get; set; }
        string VOID_NOTES { get; set; }
        string VOID_REASON { get; set; }

    }
}