using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class AcuerdoComercial
    {
        public int TRADE_AGREEMENT_ID { get; set; }

        public string CODE_TRADE_AGREEMENT { get; set; }

        public string NAME_TRADE_AGREEMENT { get; set; }

        public string DESCRIPTION_TRADE_AGREEMENT { get; set; }

        public DateTime VALID_START_DATETIME { get; set; }

        public DateTime VALID_END_DATETIME { get; set; }

        public int STATUS { get; set; }

        public DateTime LAST_UPDATE { get; set; }

        public string LAST_UPDATE_BY { get; set; }

        public string STATUS_DESCRIPTION { get; set; }

        public int CHANNEL_ID { get; set; }

        public string LINKED_TO { get; set; }
        
        public string CODE_CUSTOMER{ get; set; }


    }
}
