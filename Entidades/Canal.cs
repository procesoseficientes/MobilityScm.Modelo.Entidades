using System;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class Canal
    {
        public int CHANNEL_ID { get; set; }

        public string CODE_CHANNEL { get; set; }

        public string NAME_CHANNEL { get; set; }

        public string DESCRIPTION_CHANNEL { get; set; }

        public string TYPE_CHANNEL { get; set; }

        public DateTime? LAST_UPDATE { get; set; }

        public string LAST_UPDATE_BY { get; set; }

        public string CODE_CUSTOMER { get; set; }

        public string STATUS { get; set; }

    }
}