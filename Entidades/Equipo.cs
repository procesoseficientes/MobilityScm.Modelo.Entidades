using System;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class Equipo
    {
        public int TEAM_ID { get; set; }

        public string NAME_TEAM { get; set; }

        public int SUPERVISOR { get; set; }

        public string LOGIN { get; set; }

        public string NAME_USER { get; set; }

        public int? USER_ID { get; set; }

        public int USERS_QUANTITY { get; set; }
    }
}
