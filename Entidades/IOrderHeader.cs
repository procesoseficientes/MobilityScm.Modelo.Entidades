using System;
using System.Collections.Generic;
using System.Linq;

namespace MobilityScm.Modelo.Entidades
{
    public interface IOrderHeader
    {
        List<OrderDetail> SwiftViewSboOrderDetails { get; set; }
        int TargetEntry { get; set; }
        string DocNum{ get; set; }
        string DocEntry { get; set; }
        string CardCode { get; set; }
        string CardName { get; set; }
        Char HandWritten { get; set; }
        DateTime DocDate { get; set; }
        string Comments { get; set; }
        string DocCur { get; set; }
        decimal? DocRate { get; set; }
        decimal? DiscPrcnt { get; set; }
        string Address { get; set; }
        string Address2 { get; set; }
        string ShipToAddressType { get; set; }
        string ShipToStreet { get; set; }
        string ShipToState { get; set; }
        string ShipToCountry { get; set; }
        short? TrnspCode { get; set; }
        DateTime? DocDueDate { get; set; }
        short? SalesPersoncode { get; set; }
        string Warehouse { get; set; }
        string UEstado2 { get; set; }
        string UStatusDespacho { get; set; }
        string UUsuario { get; set; }
        string UFacserie { get; set; }
        string UFacnit { get; set; }
        string UFacnom { get; set; }
        string UTienda { get; set; }
        string USucursal { get; set; }
        string UTipoDocumento { get; set; }
        string UTotalFlete { get; set; }
        string UTipoPago { get; set; }
        string UCuotas { get; set; }
        string UTotalTarjeta { get; set; }
  
    }
}