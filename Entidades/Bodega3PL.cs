using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class Bodega3PL
    {
        public string CODE_WAREHOUSE { get; set; }
        public string WAREHOUSE_ID { get; set; }
        public string NAME { get; set; }
        public string COMMENTS { get; set; }
        public string ERP_WAREHOUSE { get; set; }
        public int? ALLOW_PICKING { get; set; }
        public string DEFAULT_RECEPTION_LOCATION { get; set; }
        public string SHUNT_NAME { get; set; }
        public string WAREHOUSE_WEATHER { get; set; }
        public int? WAREHOUSE_STATUS { get; set; }
        public int? IS_3PL_WAREHUESE { get; set; }
        public string WAHREHOUSE_ADDRESS { get; set; }
        public string GPS_URL { get; set; }
        public string DISTRIBUTION_CENTER_ID { get; set; }

        public static explicit operator Bodega3PL(DataRowCollection v)
        {
            throw new NotImplementedException();
        }
    }
}
