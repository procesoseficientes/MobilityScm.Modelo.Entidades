using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MobilityScm.Modelo.Entidades
{
    public interface IReturnDetail
    {
        List<ReturnSerieDetail> SwiftViewSboReturnSerieDetails { get; set; }
        string DocNum{ get; set; }
        string DocEntry { get; set; }
        decimal? Quantity { get; set; }
        string ItemCode { get; set; }
        string Objtype { get; set; }
        int LineNum { get; set; }
        string WarehouseCode { get; set; }
        string SalesUnit { get; set; }
        int TransactionId { get; set; }
        decimal QuantityErp { get; set; }
        string docEntryErp { get; set; }
    }
}