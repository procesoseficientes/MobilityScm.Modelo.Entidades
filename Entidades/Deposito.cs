using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class Deposito
    {
        public int TRANS_ID { get; set; }

        public string TRANS_TYPE { get; set; }

        public DateTime? TRANS_DATETIME { get; set; }

        public string BANK_ID { get; set; }

        public string ACCOUNT_NUM { get; set; }

        public decimal? AMOUNT { get; set; }

        public string POSTED_BY { get; set; }

        public DateTime? POSTED_DATETIME { get; set; }

        public string POS_TERMINAL { get; set; }

        public string GPS_URL { get; set; }

        public string IMAGE_1 { get; set; }

        public string TRANS_REF { get; set; }

        public int? IS_OFFLINE { get; set; }

        public int? STATUS { get; set; }

        public string DOC_SERIE { get; set; }

        public int? DOC_NUM { get; set; }

        public int? LIQUIDATION_ID { get; set; }

    }

}
