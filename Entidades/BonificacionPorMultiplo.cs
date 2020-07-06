using System;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class BonificacionPorMultiplo
    {
        public int TRADE_AGREEMENT_BONUS_MULTIPLE_ID { get; set; }

        public int TRADE_AGREEMENT_ID { get; set; }

        public string CODE_SKU { get; set; }

        public string DESCRIPTION_SKU { get; set; }

        public int? PACK_UNIT { get; set; }

        public string DESCRIPTION_PACK_UNIT { get; set; }

        public decimal MULTIPLE { get; set; }

        public string CODE_SKU_BONUS { get; set; }

        public int? PACK_UNIT_BONUS { get; set; }

        public string DESCRIPTION_PACK_UNIT_BONUS { get; set; }

        public decimal BONUS_QTY { get; set; }

        public string DESCRIPTION_SKU_BONUS { get; set; }
    }
}