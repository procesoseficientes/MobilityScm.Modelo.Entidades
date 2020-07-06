using System;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class ListaDePrecio
    {
        public string CODE_PRICE_LIST { get; set; }

        public string NAME_PRICE_LIST { get; set; }

        public string COMMENT { get; set; }

        public DateTime? LAST_UPDATE { get; set; }

        public string LAST_UPDATE_BY { get; set; }

        public string LOGIN { get; set; }

        public string CODE_CUSTOMER { get; set; }

        public string CODE_SKU { get; set; }
    }
}