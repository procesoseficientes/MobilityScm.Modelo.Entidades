using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class Bonificacion
    {
        public int TRADE_AGREEMENT_BONUS_ID { get; set; }

        public int TRADE_AGREEMENT_ID { get; set; }

        public string CODE_SKU { get; set; }

        public string DESCRIPTION_SKU { get; set; }

        public string CODE_FAMILY_SKU { get; set; }

        public string DESCRIPTION_FAMILY_SKU { get; set; }

        public int PACK_UNIT { get; set; }

        public string CODE_PACK_UNIT { get; set; }

        public string DESCRIPTION_PACK_UNIT { get; set; }

        public int LOW_LIMIT { get; set; }

        public int HIGH_LIMIT { get; set; }

        public string CODE_SKU_BONUS { get; set; }

        public string DESCRIPTION_SKU_BONUS { get; set; }

        public int PACK_UNIT_BONUS { get; set; }

        public string DESCRIPTION_PACK_UNIT_BONUS { get; set; }

        public int BONUS_QTY { get; set; }
    }
}
