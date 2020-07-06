using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class Frecuencia
    {
        public int ID_FREQUENCY { get; set; }

        public string CODE_FREQUENCY { get; set; }

        public int SUNDAY { get; set; }

        public int MONDAY { get; set; }

        public int TUESDAY { get; set; }

        public int WEDNESDAY { get; set; }

        public int THURSDAY { get; set; }

        public int FRIDAY { get; set; }

        public int SATURDAY { get; set; }

        public int FREQUENCY_WEEKS { get; set; }

        public DateTime LAST_WEEK_VISITED { get; set; }

        public DateTime LAST_UPDATED { get; set; }

        public string LAST_UPDATED_BY { get; set; }

        public string CODE_ROUTE { get; set; }

        public string TYPE_TASK { get; set; }

        public string CODE_CUSTOMER { get; set; }

        public string NAME_ROUTE { get; set; }

        public string VISIT_SUNDAY { get; set; }

        public string VISIT_MONDAY { get; set; }

        public string VISIT_TUESDAY { get; set; }

        public string VISIT_WEDNESDAY { get; set; }

        public string VISIT_THURSDAY { get; set; }

        public string VISIT_FRIDAY { get; set; }

        public string VISIT_SATURDAY { get; set; }

        public string VISIT_FREQUENCY_WEEKS { get; set; }

        public string TYPE_TASK_DESCRIPTION { get; set; }

        public int PRIORITY { get; set; }

        public  int POLYGON_ID { get; set; }

        public string REFERENCE_SOURCE { get; set; }

        public DateTime LAST_DATE_VISITED { get; set; }

        public string SELLER_CODE { get; set; }
        public string SELLER_NAME { get; set; }
        public string NAME_CUSTOMER { get; set; }
        public string IDS_FREQUENCY { get; set; }
        public int IS_BY_POLIGON { get; set; }
    }
}
