using System;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class TomaDeInventario
    {
        public int TAKE_INVENTORY_ID { get; set; }
        public string CLIENT_ID { get; set; }

        public string NAME_CUSTOMER { get; set; }

        public DateTime POSTED_DATETIME { get; set; }

        public string POSTED_BY { get; set; }

        public string CODE_SKU { get; set; }

        public string DESCRIPTION_SKU { get; set; }

        public string CODE_PACK_UNIT { get; set; }

        public float QTY { get; set; }
        public float LAST_QTY { get; set; }
    }
}
