using System;
using System.Collections.Generic;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class Combo
    {
        public int? COMBO_ID { get; set; }

        public string NAME_COMBO { get; set; }

        public string DESCRIPTION_COMBO { get; set; }

        public IList<SkuPorCombo> SkusPorCombo { get; set; }

        public int? QTY { get; set; }
    }
}