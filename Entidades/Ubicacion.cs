using System;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class Ubicacion
    {
        public int LOCATION { get; set; }

        public string CODE_LOCATION { get; set; }

        public string CODE_WAREHOUSE { get; set; }

        public string CLASSIFICATION_LOCATION { get; set; }

        public string HALL_LOCATION { get; set; }

        public string ALLOW_PICKING { get; set; }

        public DateTime? LAST_UPDATE { get; set; }

        public string LAST_UPDATE_BY { get; set; }
    }
}
