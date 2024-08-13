using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades.Entidades
{
    public class CreditMemo
    {
        public int ERP_RECEPTION_DOCUMENT_HEADER_ID { get; set; }

        public string TYPE { get; set; }

        public string CODE_SUPPLIER { get; set; }

        public string CODE_CLIENT { get; set; }

        public DateTime ERP_DATE { get; set; }

        public DateTime LAST_UPDATE { get; set; }

        public string LAST_UPDATE_BY { get; set; }

        public int ATTEMPTED_WITH_ERROR { get; set; }

        public int IS_POSTED_ERP { get; set; }

        public DateTime POSTED_ERP { get; set; }

        public string ERP_REFERENCE { get; set; }

        public int IS_AUTHORIZED { get; set; }

        public int IS_COMPLETE { get; set; }

        public int TASK_ID { get; set; }

        public int EXTERNAL_SOURCE_ID { get; set; }

        public string NAME_SUPPLIER { get; set; }

        public string OWNER { get; set; }

        public int IS_FROM_WAREHOUSE_TRANSFER { get; set; }
    }
}
