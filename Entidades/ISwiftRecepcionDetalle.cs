using System.Runtime.Serialization;

namespace MobilityScm.Modelo.Entidades
{
    public interface ISwiftRecepcionDetalle
    {
        string docEntry { get; set; }
        string docEntryErp { get; set; }
        string ItemCode { get; set; }
        int LineNum { get; set; }
        string ObjType { get; set; }
        decimal? Quantity { get; set; }
        string WarehouseCode { get; set; }

    }
}