using System;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class SkuParaVenta
    {
        public string SKU { get; set; }

        public string SKU_DESCRIPTION { get; set; }

        public decimal COST { get; set; }

        public int ON_HAND { get; set; }

        public int IS_COMITED { get; set; }

        public int DIFERENCE { get; set; }
        
    }
}