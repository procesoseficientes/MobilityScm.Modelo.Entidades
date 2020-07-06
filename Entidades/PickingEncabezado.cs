using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class PickingEncabezado
    {
        public int PICKING_HEADER { get; set; }

        public string CLASSIFICATION_PICKING { get; set; }

        public string CODE_CLIENT { get; set; }

        public string CODE_USER { get; set; }

        public string REFERENCE { get; set; }

        public string DOC_SAP_RECEPTION { get; set; }

        public string STATUS { get; set; }

        public DateTime LAST_UPDATE { get; set; }

        public string LAST_UPDATE_BY { get; set; }

        public string COMMENTS { get; set; }

        public DateTime SCHEDULE_FOR { get; set; }

        public int SEQ { get; set; }

        public string FF { get; set; }

        public string FF_STATUS { get; set; }

        public string CODE_WAREHOUSE_SOURCE { get; set; }

        public string CODE_SELLER { get; set; }

        public string CODE_ROUTE { get; set; }

        public IList<PickingDetalle> Detalles { get; set; }

        public int SOURCE_DOC { get; set; }

        public string ERP_REFERENCE { get; set; }

        public int SALES_ORDER_ID { get; set; }

        public bool IS_FROM_SONDA { get; set; }

        public int? TASK_ID { get; set; }

        public string LOGIN { get; set; }
    }
}
