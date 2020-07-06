using System;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class BonoPorMontoGeneralDePromo
    {
        public int PROMO_BONUS_BY_GENERAL_AMOUNT_ID { get; set; }

        public int PROMO_ID { get; set; }

        public double LOW_LIMIT { get; set; }

        public double HIGH_LIMIT { get; set; }

        public string CODE_SKU_BONUS { get; set; }

        public string DESCRIPTION_SKU { get; set; }

        public int? PACK_UNIT_BONUS { get; set; }

        public string DESCRIPTION_PACK_UNIT { get; set; }

        public double BONUS_QTY { get; set; }
    }
}
