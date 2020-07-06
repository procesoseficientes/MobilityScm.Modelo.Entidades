using System;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class FrecuenciaDeCliente
    {
        public int CODE_FREQUENCY { get; set; }

        public string CODE_CUSTOMER { get; set; }

        public string SUNDAY { get; set; }

        public string MONDAY { get; set; }

        public string TUESDAY { get; set; }

        public string WEDNESDAY { get; set; }

        public string THURSDAY { get; set; }

        public string FRIDAY { get; set; }

        public string SATURDAY { get; set; }

        public string FREQUENCY_WEEKS { get; set; }

        public DateTime? LAST_DATE_VISITED { get; set; }

        public DateTime? LAST_UPDATED { get; set; }

        public string LAST_UPDATED_BY { get; set; }
    }
}