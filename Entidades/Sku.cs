using System;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class Sku
    {
        public int SKU { get; set; }

        public string CODE_SKU { get; set; }

        public string DESCRIPTION_SKU { get; set; }

        public string CLASSIFICATION_SKU { get; set; }

        public string BARCODE_SKU { get; set; }

        public string CODE_PROVIDER { get; set; }

        public float? COST { get; set; }

        public string MEASURE { get; set; }

        public DateTime? LAST_UPDATE { get; set; }

        public string LAST_UPDATE_BY { get; set; }

        public string HANDLE_SERIAL_NUMBER { get; set; }

        public string HANDLE_BATCH { get; set; }

        public int? UNIT_MEASURE_SKU { get; set; }

        public decimal? WEIGHT_SKU { get; set; }

        public decimal? VOLUME_SKU { get; set; }

        public decimal? LONG_SKU { get; set; }

        public decimal? WIDTH_SKU { get; set; }

        public decimal? HIGH_SKU { get; set; }

        public int FAMILY_SKU { get; set; }

        public string CODE_FAMILY_SKU { get; set; }

        public string DESCRIPTION_FAMILY_SKU { get; set; }

        public int PACK_UNIT { get; set; }

        public string CODE_PACK_UNIT { get; set; }

        public string DESCRIPTION_PACK_UNIT { get; set; }

        public int ID { get; set; }
    }

}