using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class CentroDeDistribucion
    {
        public int? DISTRIBUTION_CENTER_ID { get; set; }

        public string NAME_DISTRIBUTION_CENTER { get; set; }

        public string DESCRIPTION_DISTRIBUTION_CENTER { get; set; }

        public string LOGO_IMG { get; set; }

        public string LAST_UPDATE_BY { get; set; }

        public DateTime? LAST_UPDATE_DATETIME { get; set; }

        public string ADRESS_DISTRIBUTION_CENTER { get; set; }

        public string LATITUDE { get; set; }

        public string LONGITUDE { get; set; }
    }
}
