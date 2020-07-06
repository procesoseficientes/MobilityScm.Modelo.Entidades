using System;
using System.Collections.Generic;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class ReglaDeBonificacionDeCombo
    {
        public int TRADE_AGREEMENT_BONUS_RULE_BY_COMBO_ID { get; set; }

        public int COMBO_ID { get; set; }

        public string BONUS_TYPE { get; set; }

        public string BONUS_SUB_TYPE { get; set; }

        public int IS_BONUS_BY_LOW_PURCHASE { get; set; }

        public int IS_BONUS_BY_COMBO { get; set; }

        public int LOW_QTY { get; set; }

        public int TRADE_AGREEMENT_ID { get; set; }

        public IList<Sku> SkusParaBonificar { get; set; }
}
}