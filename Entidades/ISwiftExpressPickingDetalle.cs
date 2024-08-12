using System.Runtime.Serialization;

namespace MobilityScm.Modelo.Entidades
{
    public interface ISwiftExpressPickingDetalle
    {
        string docEntryErp { get; set; }
        int DoEntry { get; set; }
        string ItemCode { get; set; }
        int LineNum { get; set; }
        int ObjType { get; set; }
        int Quantity { get; set; }
        string TaxCode { get; set; }

        string U_FAMILIA { get; set; }
        string AcctCode { get; set; }
        string CogsAcct { get; set; }
    }
}
