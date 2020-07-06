using System;
using System.Collections.Generic;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class ReglaDeBoniPorComboDePromo
    {
        public int PROMO_RULE_BY_COMBO_ID { get; set; }                   

        public int COMBO_ID { get; set; }

        public string BONUS_TYPE { get; set; }

        public string BONUS_SUB_TYPE { get; set; }

        public int IS_BONUS_BY_LOW_PURCHASE { get; set; }

        public int IS_BONUS_BY_COMBO { get; set; }

        public int LOW_QTY { get; set; }

        public int PROMO_ID { get; set; }
        
    }
}
