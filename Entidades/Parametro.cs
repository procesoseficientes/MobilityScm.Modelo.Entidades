using System;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class Parametro
    {
        public int IDENTITY { get; set; }

        public string GROUP_ID { get; set; }

        public string PARAMETER_ID { get; set; }

        public string VALUE { get; set; }
    }
}
