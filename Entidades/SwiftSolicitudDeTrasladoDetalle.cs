using System;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class SwiftSolicitudDeTrasladoDetalle
    {
        public string MATERIAL_ID { get; set; }
        public string MATERIAL_NAME { get; set; }
        public decimal QTY { get; set; }
        public int LINE_NUM { get; set; }       
    }
}
