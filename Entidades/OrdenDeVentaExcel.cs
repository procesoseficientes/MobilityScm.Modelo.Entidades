using System;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class OrdenDeVentaExcel
    {
        public string SKU { get; set; }
        
        public string CLIENT_ID { get; set; }

        public string POSTED_DATETIME { get; set; }

        public string QTY { get; set; }

    }
}