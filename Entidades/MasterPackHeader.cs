using System;

namespace MobilityScm.Modelo.Entidades
{
    public class MasterPackHeader
    {
        public int MASTER_PACK_HEADER_ID { get; set; }
        public int LICENSE_ID { get; set; }
        public string MATERIAL_ID { get; set; }
        public string MATERIAL_NAME { get; set; }
        public int POLICY_HEADER_ID { get; set; }
        public string CODE_POLICY_HEADER { get; set; }
        public DateTime  LAST_UPDATED { get; set; }
        public string LAST_UPDATE_BY { get; set; }
        public int EXPLODED { get; set; }
        public DateTime EXPLODED_DATE { get; set; }
        public DateTime RECEPTION_DATE { get; set; }
        public int IS_AUTHORIZED { get; set; }
        public int ATTEMPTED_WITH_ERROR { get; set; }
        public int IS_POSTED_ERP { get; set; }
        public DateTime POSTED_ERP { get; set; }
        public string POSTED_RESPONSE { get; set; }
        public string ERP_REFERENCE { get; set; }
        public int IS_IMPLOSION { get; set; }
    }
}
