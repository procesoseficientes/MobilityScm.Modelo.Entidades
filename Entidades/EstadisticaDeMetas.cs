using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class EstadisticaDeMetas
    {
        public int STATISTICS_GOAL_BY_SALE_ID { get; set; }

        public int? GOAL_HEADER_ID { get; set; }

        public int? TEAM_ID { get; set; }

        public int? USER_ID { get; set; }

        public int? SELLER_CODE { get; set; }

        public string SELLER_NAME { get; set; }

        public string CODE_ROUTE { get; set; }

        public string NAME_ROUTE { get; set; }

        public int? RANKING { get; set; }

        public decimal? DAILY_GOAL { get; set; }

        public decimal? ACCUMULATED_BY_PERIOD { get; set; }

        public decimal? PERCENTAGE_GOAL_DAILY { get; set; }

        public int? DAYS_OF_SALE { get; set; }

        public int? REMAINING_DAYS { get; set; }

        public decimal? PERCENTAGE_OF_DAYS { get; set; }

        public decimal? GENERAL_GOAL { get; set; }

        public decimal? DIFFERENCE_FROM_THE_GOAL { get; set; }

        public decimal? NEXT_SALE_GOAL { get; set; }

        public decimal? PERCENTAGE_OF_GENERAL_GOAL { get; set; }

        public decimal? SALE_OF_THE_DAY { get; set; }

        public DateTime? SALES_DATE { get; set; }

        public DateTime? CREATED_DATE { get; set; }

        public int? LAST_CREATED { get; set; }

        public string SALE_TYPE { get; set; }
    }
}
