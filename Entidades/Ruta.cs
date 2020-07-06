using System;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class Ruta
    {
        public int ROUTE { get; set; }

        public string CODE_ROUTE { get; set; }

        public string NAME_ROUTE { get; set; }

        public string GEOREFERENCE_ROUTE { get; set; }

        public string COMMENT_ROUTE { get; set; }

        public string LOGIN { get; set; }

        public string SELLER_CODE { get; set; }
        
        public string SELLER_NAME { get; set; }

        public string CODE_VEHICLE { get; set; }

        public string NAME_USER { get; set; }

        public DateTime STAR_DATE { get; set; }

        public DateTime END_DATE { get; set; }

        public string TYPE_USER_DESCRIPTION { get; set; }

        public int? TRADE_AGREEMENT_ID { get; set; }

        public string ASSIGNED { get; set; }
    }
}
