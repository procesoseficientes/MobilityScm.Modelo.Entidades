using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class DescuentoDeAcuerdoComercial
    {
        public int TRADE_AGREEMENT_DISCUOUNT_ID { get; set; }

        public int TRADE_AGREEMENT_ID { get; set; }

        public string CODE_SKU { get; set; }

        public string DESCRIPTION_SKU { get; set; }

        public decimal DISCOUNT { get; set; }

        public string CODE_FAMILY_SKU { get; set; }

        public string DESCRIPTION_FAMILY_SKU { get; set; }

        public int PACK_UNIT { get; set; }

        public string CODE_PACK_UNIT { get; set; }

        public string DESCRIPTION_PACK_UNIT { get; set; }

        public int LOW_LIMIT { get; set; }

        public int HIGH_LIMIT { get; set; }

        public int? ID { get; set; }
    }
}
