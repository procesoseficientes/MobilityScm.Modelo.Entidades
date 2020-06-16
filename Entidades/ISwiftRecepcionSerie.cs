using System.Runtime.Serialization;

namespace MobilityScm.Modelo.Entidades
{
    public interface ISwiftRecepcionSerie
    {
        string docEntry { get; set; }
        string ItemCode { get; set; }
        // ReSharper disable once InconsistentNaming
        string STATUS { get; set; }
        string TxnSerie { get; set; }

    }
}