using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class MetaDetalle
    {
        public int GOAL_DETAIL_ID { get; set; }
        public int GOAL_HEADER_ID { get; set; }
        public int SELLER_ID { get; set; }
        public decimal GOAL_BY_SELLER { get; set; }
        public decimal DAILY_GOAL_BY_SELLER { get; set; }
        public string SELLER_NAME { get; set; }
        public int CORRELATIVE { get; set; }
        public string LOGIN { get; set; }
        public string NAME_USER { get; set; }
    }
}
