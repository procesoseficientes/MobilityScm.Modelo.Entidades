using System.Runtime.Serialization;

namespace MobilityScm.Modelo.Entidades
{
    public interface IOrderSerieDetail
    {
        int TransactionId { get; set; }
        string DocEntry { get; set; }
        string ItemCode { get; set; }
        int LineNum { get; set; }
        string TxnSerie { get; set; }
        int SysNumber { get; set; }
        
    }
}