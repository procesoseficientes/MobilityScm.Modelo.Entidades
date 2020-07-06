using System;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class Promo
    {
        public int? PROMO_ID { get; set; }

        public string PROMO_NAME { get; set; }

        public string PROMO_TYPE { get; set; }

        public int TRADE_AGREEMENT_ID { get; set; }

        public string FREQUENCY { get; set; }

    }
}
