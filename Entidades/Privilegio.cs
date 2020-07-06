using System;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class Privilegio
    {
        public decimal ID { get; set; }

        public string PRIVILEGE_ID { get; set; }

        public string PARENT_ID { get; set; }

        public decimal SEQUENCE { get; set; }

        public string NAME { get; set; }

        public string PRIVILEGE_TYPE { get; set; }

        public string DISPLAY_NAME { get; set; }

        public string IMAGE_URL { get; set; }

        public string DESCRIPTION { get; set; }

        public bool ACTIVE { get; set; }

        public string URL { get; set; }

        public int? IS_PATER { get; set; }

        public string ACCESS { get; set; }

        public int IS_SCREEN { get; set; }
    }
}
