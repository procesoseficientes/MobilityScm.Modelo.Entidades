using System;
using System.Runtime.Serialization;

namespace MobilityScm.Modelo.Entidades
{
    public interface ISondaFacturaDetalle
    {
        string COMBO_REFERENCE { get; set; }
        decimal? DISCOUNT { get; set; }
        int INVOICE_ID { get; set; }
        string INVOICE_RESOLUTION { get; set; }
        string INVOICE_SERIAL { get; set; }
        int? IS_ACTIVE_ROUTE { get; set; }
        int LINE_SEQ { get; set; }
        int? PARENT_SEQ { get; set; }
        DateTime? POSTED_DATETIME { get; set; }
        decimal? PRICE { get; set; }
        decimal? QTY { get; set; }
        int? REQUERIES_SERIE { get; set; }
        string SERIE { get; set; }
        string SERIE_2 { get; set; }
        string SKU { get; set; }
        decimal? TOTAL_LINE { get; set; }
        string TAX_ID { get; set; }

    }
}