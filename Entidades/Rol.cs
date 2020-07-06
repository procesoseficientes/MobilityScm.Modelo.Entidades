using System;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class Rol
    {
        public decimal ROLE_ID { get; set; }

        public string NAME { get; set; }

        public string DESCRIPTION { get; set; }

        public DateTime LAST_UPDATED { get; set; }

        public string LAST_UPDATED_BY { get; set; }
    }
}