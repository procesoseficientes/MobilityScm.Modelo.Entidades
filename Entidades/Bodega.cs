using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class Bodega
    {
        public int WAREHOUSE { get; set; }

        public string CODE_WAREHOUSE { get; set; }

        public string DESCRIPTION_WAREHOUSE { get; set; }

        public string WEATHER_WAREHOUSE { get; set; }

        public string STATUS_WAREHOUSE { get; set; }

        public int IS_EXTERNAL { get; set; }
        public int WAREHOUSE_X_ZONE_ID { get; set; }

        public string ADDRESS_WAREHOUSE { get; set; }

        public int SALES_OFFICE_ID { get; set; }

    }
}
