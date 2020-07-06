using System;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class ManifiestoEncabezado
    {
        public int MANIFEST_HEADER { get; set; }

        public string CODE_MANIFEST_HEADER { get; set; }

        public string CODE_DRIVER { get; set; }

        public string NAME_DRIVER { get; set; }

        public string CODE_VEHICLE { get; set; }

        public string COMMENTS { get; set; }

        public string STATUS { get; set; }

        public DateTime? LAST_UPDATE { get; set; }

        public string LAST_UPDATE_BY { get; set; }

        public string CODE_ROUTE { get; set; }

        public DateTime? CREATED_DATE { get; set; }

        public DateTime? ACCEPTED_STAMP { get; set; }

        public DateTime? COMPLETED_STAMP { get; set; }

        public string PLATE_VEHICLE { get; set; }

        public string NAME_ROUTE { get; set; }

        public decimal PERCENTAGE { get; set; }

        public DateTime START_DATE { get; set; }

        public DateTime END_DATE { get; set; }
        public decimal DISTANCE_IN_KMS { get; set; }
        public string MANIFEST_SOURCE { get; set; }
    }
}
