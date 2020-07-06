using System;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class Demo
    {
        public int? SKU { get; set; }

        public string CODE_SKU { get; set; }

        public string DESCRIPTION_SKU { get; set; }

        public string VALUE_TEXT_CLASSIFICATION { get; set; }

        public string BARCODE_SKU { get; set; }

        public string CODE_PROVIDER { get; set; }

        public float? LIST_PRICE { get; set; }

        public float? COST { get; set; }

        public string MEASURE { get; set; }

        public DateTime? LAST_UPDATE { get; set; }

        public string LAST_UPDATE_BY { get; set; }

        public string HANDLE_SERIAL_NUMBER { get; set; }

        public string HANDLE_BATCH { get; set; }

        public int? FROM_ERP { get; set; }
    }

}
