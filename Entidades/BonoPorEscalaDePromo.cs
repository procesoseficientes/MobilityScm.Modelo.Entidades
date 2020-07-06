using System;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class BonoPorEscalaDePromo
    {
        public int PROMO_BONUS_BY_SCALE_ID { get; set; }

        public int? PROMO_ID { get; set; }

        public string CODE_SKU { get; set; }

        public string DESCRIPTION_SKU { get; set; }

        public int? PACK_UNIT { get; set; }

        public string DESCRIPTION_PACK_UNIT { get; set; }

        public decimal LOW_LIMIT { get; set; }

        public decimal HIGH_LIMIT { get; set; }

        public string CODE_SKU_BONUS { get; set; }

        public string DESCRIPTION_BONUS_SKU { get; set; }

        public int? PACK_UNIT_BONUS { get; set; }

        public string DESCRIPTION_PACK_UNIT_BONUS { get; set; }

        public decimal BONUS_QTY { get; set; }
    }
}
