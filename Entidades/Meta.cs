using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class Meta
    {
        public int? GOAL_HEADER_ID { get; set; }
        public string GOAL_NAME { get; set; }
        public int? TEAM_ID { get; set; }
        public int? SUPERVISOR_ID { get; set; }
        public decimal GOAL_AMOUNT { get; set; }
        public DateTime GOAL_DATE_FROM { get; set; }
        public DateTime GOAL_DATE_TO { get; set; }
        public string GOAL_CLOSE_DATE { get; set; }
        public string STATUS { get; set; }
        public int INCLUDE_SATURDAY { get; set; }
        public DateTime LAST_UPDATE { get; set; }
        public string LAST_UPDATE_BY { get; set; }
        public string CLOSED_BY { get; set; }
        public string SALE_TYPE { get; set; }
        public int PERIOD_DAYS { get; set; }
        public string NAME_TEAM { get; set; }
        public string STATUS_DESCRIPTION{get;set;}
    }
}
