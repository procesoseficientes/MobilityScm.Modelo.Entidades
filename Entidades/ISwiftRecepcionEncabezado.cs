using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MobilityScm.Modelo.Entidades
{
    public interface ISwiftRecepcionEncabezado
    {
        
        string CardCode { get; set; }
        string CardName { get; set; }
        string Comments { get; set; }
        string DocCur { get; set; }
        DateTime DocDate { get; set; }
        string DocEntry { get; set; }
        string DocNum { get; set; }
        decimal? DocRate { get; set; }
        char HandWritten { get; set; }
        List<SwiftRecepcionDetalle> SwiftRecepcionDetalle { get; set; }
        List<SwiftRecepcionSerie> SwiftRecepcionSeries { get; }
        int TargetEntry { get; set; }
        string UCuotas { get; set; }
        string UFacfecha { get; set; }
        string UFacnit { get; set; }
        string UFacnom { get; set; }
        string UFacnum { get; set; }
        string UFacserie { get; set; }
        string UFechap { get; set; }
        string UNoExencion { get; set; }
        string UStatusNc { get; set; }
        string USucursal { get; set; }
        string UTienda { get; set; }
        string UTipoDocumento { get; set; }
        string UTipoPago { get; set; }
        string UTotalFlete { get; set; }
        string UTotalTarjeta { get; set; }
        string UTrasladooc { get; set; }
        string UUsuario { get; set; }

    }
}