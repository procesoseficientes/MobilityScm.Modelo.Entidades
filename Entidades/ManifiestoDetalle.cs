using System;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class ManifiestoDetalle
    {
        public int MANIFEST_DETAIL { get; set; }

        public string CODE_MANIFEST_HEADER { get; set; }

        public string CODE_PICKING { get; set; }

        public DateTime? LAST_UPDATE { get; set; }

        public string LAST_UPDATE_BY { get; set; }

        public string CODE_CUSTOMER { get; set; }

        public string REFERENCE { get; set; }

        public string DOC_SAP_RECEPTION { get; set; }

        public string DOC_SAP_PICKING { get; set; }

        public string TYPE { get; set; }

        public int? DELIVERY_TASK { get; set; }

        public string REJECT_COMMENT { get; set; }
        
        public string IMAGE_1 { get; set; }

        public string EXPECTED_GPS_LATITUDE { get; set; }

        public string EXPECTED_GPS_LONGITUDE { get; set; }
        
        public string POSTED_GPS_LATITUDE { get; set; }

        public string POSTED_GPS_LONGITUDE { get; set; }
        
        public string TASK_STATUS { get; set; }

        public string EXPECTED_GPS { get; set; }
        
        public string POSTED_GPS { get; set; }
        
        public string CUSTOMER_NAME { get; set; }

        public string STATUS { get; set; }

        public decimal GPS_DISTANCE { get; set; }

        public DateTime ASSIGNED_STAMP { get; set; }

        public DateTime ACCEPTED_STAMP { get; set; }

        public DateTime COMPLETED_STAMP { get; set; }

        public int TASK_SEQ { get; set; }
    }
}
