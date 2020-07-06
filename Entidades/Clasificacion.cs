using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class Clasificacion
    {
        public int CLASSIFICATION { get; set; }

        public string GROUP_CLASSIFICATION { get; set; }

        public string NAME_CLASSIFICATION { get; set; }

        public int? PRIORITY_CLASSIFICATION { get; set; }

        public string VALUE_TEXT_CLASSIFICATION { get; set; }

        public DateTime? LAST_UPDATE { get; set; }

        public string LAST_UPDATE_BY { get; set; }

        public string MPC01 { get; set; }
        
    }
}
