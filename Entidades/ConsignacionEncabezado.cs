using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class ConsignacionEncabezado{
        public int CONSIGNMENT_ID { get; set; }

        public DateTime DATE_CREATE { get; set; }

        public string CUSTOMER_ID { get; set; }

        public DateTime? DATE_UPDATE { get; set; }

        public string STATUS { get; set; }

        public string POSTED_BY { get; set; }

        public int? IS_POSTED { get; set; }

        public string POS_TERMINAL { get; set; }

        public string GPS_URL { get; set; }

        public DateTime? DOC_DATE { get; set; }

        public DateTime? CLOSED_ROUTE_DATETIME { get; set; }

        public int? IS_ACTIVE_ROUTE { get; set; }

        public DateTime? DUE_DATE { get; set; }

        public IList<ConsignacionDetalle> Detalles { get; set; }

        public int CONSIGNMENT_HH_NUM { get; set; }        

        public decimal? TOTAL_AMOUNT { get; set; }

        public string DOC_SERIE { get; set; }

        public int? DOC_NUM { get; set; }

        public string IMG { get; set; }

        public int? IS_CLOSED { get; set; }

        public string REASON { get; set; }
        public string IS_CLOSED_DESCRIPTION { get; set; }

        public string NAME_CUSTOMER { get; set; }

        public string LATITUDE { get; set; }

        public string LONGITUDE { get; set; }

        public int KPI { get; set; }
    }
}
