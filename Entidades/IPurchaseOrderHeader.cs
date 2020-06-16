using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MobilityScm.Modelo.Entidades
{
    public interface IPurchaseOrderHeader
    {
        List<PurchaseOrderDetail> SwiftViewSboPurchaseOrderDetails { get; set; }
        int TargetEntry { get; set; }
        string DocNum { get; set; }
        string DocEntry { get; set; }
        string CardCode { get; set; }
        string CardName { get; set; }
        Char HandWritten { get; set; }
        DateTime DocDate { get; set; }
        string Comments { get; set; }
        string DocCur { get; set; }
        decimal? DocRate { get; set; }
        string UFacserie { get; set; }
        string UFacnit { get; set; }
        string UFacnom { get; set; }
        string UFacfecha { get; set; }
        string UTienda { get; set; }
        string UStatusNc { get; set; }
        string UNoExencion { get; set; }
        string UTipoDocumento { get; set; }
        string UUsuario { get; set; }
        string UFacnum { get; set; }
        string USucursal { get; set; }
        string UTotalFlete { get; set; }
        string UTipoPago { get; set; }
        string UCuotas { get; set; }
        string UTotalTarjeta { get; set; }
        string UFechap { get; set; }
        string UTrasladooc { get; set; }
    }
}