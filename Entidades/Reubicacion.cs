using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class Reubicacion
    {
        public int ID_RELOCATE { get; set; }

        public DateTime? LAST_UPDATE { get; set; }

        public string LAST_UPDATE_BY { get; set; }

        public string WAREHOUSE_TARGET { get; set; }

        public string LOCATION_TARGET { get; set; }

        public string WAREHOUSE_SOURCE { get; set; }

        public string LOCATION_SOURCE { get; set; }

        public string CODE_SKU { get; set; }

        public int? QTY { get; set; }

        public DateTime? START_DATE { get; set; }

        public DateTime? END_DATE { get; set; }
        
        public int ON_HAND { get; set; }
        
        public int INVENTORY { get; set; }
        
        public string SERIAL_NUMBER { get; set; }
        
        public string WAREHOUSE { get; set; }
        
        public string LOCATION { get; set; }
        
        public string SKU { get; set; }

        public string DESCRIPTION_SKU { get; set; }
        
        public string USER { get; set; }

        public string WAREHOUSE_TARGET_NAME { get; set; }

        public string WAREHOUSE_SOURCE_NAME { get; set; }

        public string NAME_SKU { get; set; }
        
    }
}
