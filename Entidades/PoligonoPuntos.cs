using System;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class PoligonoPuntos
    {
        public int POLYGON_ID { get; set; }

        public int POSITION { get; set; }

        public string LATITUDE { get; set; }

        public string LONGITUDE { get; set; }

    }
}
