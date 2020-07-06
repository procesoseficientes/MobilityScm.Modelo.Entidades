using System;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class ResolucionSat
    {
        public int ROWPK { get; set; }

        public string AUTH_ID { get; set; }

        public DateTime? AUTH_ASSIGNED_DATETIME { get; set; }

        public DateTime? AUTH_POST_DATETIME { get; set; }

        public string AUTH_ASSIGNED_BY { get; set; }

        public int? AUTH_DOC_FROM { get; set; }

        public int? AUTH_DOC_TO { get; set; }

        public string AUTH_SERIE { get; set; }

        public string AUTH_DOC_TYPE { get; set; }

        public string AUTH_ASSIGNED_TO { get; set; }

        public int? AUTH_CURRENT_DOC { get; set; }

        public DateTime? AUTH_LIMIT_DATETIME { get; set; }

        public string AUTH_STATUS { get; set; }

        public string AUTH_BRANCH_NAME { get; set; }

        public string AUTH_BRANCH_ADDRESS { get; set; }

        public string AUTH_TYPE { get; set; }
    }
}