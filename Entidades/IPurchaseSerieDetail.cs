using System.Runtime.Serialization;

namespace MobilityScm.Modelo.Entidades
{
    public interface IPurchaseSerieDetail
    {
        int TransactionId { get; set; }
        string DocEntry { get; set; }
        string ItemCode { get; set; }
        int LineNum { get; set; }
        string TxnSerie { get; set; }
        
    }
}