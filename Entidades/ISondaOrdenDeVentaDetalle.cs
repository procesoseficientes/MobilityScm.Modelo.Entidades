using System;

namespace MobilityScm.Modelo.Entidades
{
    public interface ISondaOrdenDeVentaDetalle
    {
        int SALES_ORDER_ID { get; set; }
        string SKU { get; set; }
        int LINE_SEQ { get; set; }
        decimal? QTY { get; set; }
        decimal? PRICE { get; set; }
        decimal? DISCOUNT { get; set; }
        decimal? TOTAL_LINE { get; set; }
        DateTime? POSTED_DATETIME { get; set; }
        string SERIE { get; set; }
        string SERIE_2 { get; set; }
        int? REQUERIES_SERIE { get; set; }
        string COMBO_REFERENCE { get; set; }
        int? PARENT_SEQ { get; set; }
        int? IS_ACTIVE_ROUTE { get; set; }
        string UM_CODE { get; set; }
        double DISC_PRCNT { get; set; }
        int UM_ENTRY { get; set; }
        decimal? LONG { get; set; }
        string OWNER {get;set;}
}
}