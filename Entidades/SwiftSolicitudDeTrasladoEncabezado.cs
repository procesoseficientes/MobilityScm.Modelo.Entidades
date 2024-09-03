using System;
using System.Collections.Generic;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class SwiftSolicitudDeTrasladoEncabezado
    {
        public int TRANSFER_REQUEST_ID { get; set; }
        public string REQUEST_TYPE { get; set; }
        public string WAREHOUSE_FROM { get; set; }
        public string WAREHOUSE_TO { get; set; }
        public DateTime? REQUEST_DATE { get; set; }
        public DateTime? DELIVERY_DATE { get; set; }
        public string COMMENT { get; set; }
        public string STATUS { get; set; }
        public string CREATED_BY { get; set; }
        public DateTime? LAST_UPDATE { get; set; }
        public string LAST_UPDATE_BY { get; set; }
        public string OWNER { get; set; }
        public string CLIENT_CODE { get; set; }
        public string CLIENT_NAME { get; set; }
        public int DOC_ENTRY { get; set; }
        public string U_SUCURSAL { get; set; }
        public string U_Cajas { get; set; }
        public List<SwiftSolicitudDeTrasladoDetalle> SwiftSolicitudDeTrasladoDetalle { get; set; }
    }
}
