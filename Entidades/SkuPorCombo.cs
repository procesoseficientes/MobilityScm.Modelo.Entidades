﻿using System;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class SkuPorCombo
    {
        public int ID { get; set; }
        public int COMBO_ID { get; set; }

        public string CODE_SKU { get; set; }

        public int PACK_UNIT { get; set; }

        public int QTY { get; set; }

        public string DESCRIPTION_SKU { get; set; }

        public string CODE_PACK_UNIT { get; set; }

        public string DESCRIPTION_PACK_UNIT { get; set; }

        public int? FAMILY_SKU { get; set; }

        public string CODE_FAMILY_SKU { get; set; }

        public string DESCRIPTION_FAMILY_SKU { get; set; }
    }
}