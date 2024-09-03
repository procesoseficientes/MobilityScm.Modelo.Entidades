using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MobilityScm.Modelo.Entidades
{
    public interface ISwiftPickingEncabezado
    {
        List<SwiftExpressPickingDetalle> SwiftExpressPickingDetalle { get; }
        List<SwiftPickingSerie> SwiftPickingSeries { get; }
        string DocEntry { get; set; }
        string DocNum{ get; set; }
        string Classification { get; set; }
        string CardCode { get; set; }
        string CardName { get; set; }
        string HandWritten { get; set; }
        DateTime DocDate { get; set; }
        string Comments { get; set; }
        string DocCur { get; set; }
        decimal DocRate { get; set; }
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
        string UFacSerie { get; set; }
        string StringUFacNit { get; set; }
        string UFacNom { get; set; }
        string UFacFecha { get; set; }
        string StringUTienda { get; set; }
        string UStatusNc { get; set; }
        string UUsuario { get; set; }
        string UFacnum { get; set; }
        string USucursal { get; set; }
        string U_Total_Flete { get; set; }
        string UTipoPago { get; set; }
        string UCuotas { get; set; }
        string UTotalTarjeta { get; set; }
        string UFechap { get; set; }
        string UTrasladoOC { get; set; }
        string UEstado2 { get; set; }
        string UStatusDespacho { get; set; }
        string UFacserie { get; set; }
        string UFacnit { get; set; }
        string UFacnom { get; set; }
        string UTienda { get; set; }
        string UTipoDocumento { get; set; }
        string UTotalFlete { get; set; }

        int PICKING_HEADER { get; set; }
        string CLASSIFICATION_PICKING { get; set; }
        string CODE_CLIENT { get; set; }
        string NAME_CUSTOMER { get; set; }
        string ADRESS_CUSTOMER { get; set; }
        string CODE_USER { get; set; }
        string REFERENCE { get; set; }
        string DOC_SAP_RECEPTION { get; set; }
        string STATUS { get; set; }
        DateTime? LAST_UPDATE { get; set; }
        string LAST_UPDATE_BY { get; set; }
        string COMMENTS { get; set; }
        DateTime SCHEDULE_FOR { get; set; }
        int SEQ { get; set; }
        string FF { get; set; }
        string FF_STATUS { get; set; }
        int? ATTEMPTED_WITH_ERROR { get; set; }
        int? IS_POSTED_ERP { get; set; }
        DateTime? POSTED_ERP { get; set; }
        string POSTED_RESPONSE { get; set; }
        string CODE_WAREHOUSE_SOURCE { get; set; }
        string SOURCE_DOC_TYPE { get; set; }
        int? SOURCE_DOC { get; set; }
        int? TARGET_DOC { get; set; }
        string CODE_SELLER { get; set; }
        string CODE_ROUTE { get; set; }
        string ERP_REFERENCE { get; set; }

        int HAS_MASTERPACK { get; set; }

        int POSTED_STATUS { get; set; }

        string CODE_WAREHOUSE { get; set; }
        string OWNER { get; set; }
        int PERFORMS_INTERNAL_SALE { get; set; }
        int INTERNAL_SALE_INTERFACE { get; set; }
        string INTERNAL_SALE_COMPANY { get; set; }
        string INNER_SALE_STATUS { get; set; }
        string SERIAL_NUMBER { get; set; }
        string TAX_ID { get; set; }
        string CARD_NAME { get; set; }

        //Campos Ferco
        string U_Bodega { get; set; }
        string NumAtCard { get; set; }
        DateTime? U_FacFecha { get; set; }
        string U_FacNit { get; set; }
        string U_FacNom { get; set; }
        string U_Sucursal { get; set; }
        string U_MotivoAuto { get; set; }
        int U_Cajas {  get; set; }

    }
}