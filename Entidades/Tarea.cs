using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class Tarea
    {
        public int TASK_ID { get; set; }

        public string TASK_TYPE { get; set; }

        public string TASK_TYPE_DESCRIPTION { get; set; }

        public DateTime? TASK_DATE { get; set; }

        public DateTime? SCHEDULE_FOR { get; set; }

        public DateTime? CREATED_STAMP { get; set; }

        public string ASSIGEND_TO { get; set; }

        public string NAME_USER { get; set; }
    
        public string CODE_ROUTE { get; set; }

        public string NAME_ROUTE { get; set; }

        public string ASSIGNED_BY { get; set; }

        public DateTime? ASSIGNED_STAMP { get; set; }

        public DateTime? CANCELED_STAMP { get; set; }

        public string CANCELED_BY { get; set; }

        public DateTime? ACCEPTED_STAMP { get; set; }

        public DateTime? COMPLETED_STAMP { get; set; }

        public string RELATED_PROVIDER_CODE { get; set; }

        public string RELATED_PROVIDER_NAME { get; set; }

        public string EXPECTED_GPS { get; set; }

        public string POSTED_GPS { get; set; }

        public string TASK_STATUS { get; set; }

        public string TASK_STATUS_DESCIPTION { get; set; }

        public string TASK_COMMENTS { get; set; }

        public int? TASK_SEQ { get; set; }

        public string REFERENCE { get; set; }

        public string SAP_REFERENCE { get; set; }

        public string COSTUMER_CODE { get; set; }

        public string COSTUMER_NAME { get; set; }

        public int? RECEPTION_NUMBER { get; set; }

        public int? PICKING_NUMBER { get; set; }

        public string COUNT_ID { get; set; }

        public string ACTION { get; set; }

        public string SCANNING_STATUS { get; set; }

        public int? ALLOW_STORAGE_ON_DIFF { get; set; }

        public string CUSTOMER_PHONE { get; set; }

        public string TASK_ADDRESS { get; set; }

        public DateTime? VISIT_HOUR { get; set; }

        public int? ROUTE_IS_COMPLETED { get; set; }

        public string EMAIL_TO_CONFIRM { get; set; }

        public float? DISTANCE_IN_KMS { get; set; }

        public string DOC_RESOLUTION { get; set; }

        public string DOC_SERIE { get; set; }

        public int? DOC_NUM { get; set; }

        public decimal? COMPLETED_SUCCESSFULLY { get; set; }

        public string COMPLETED_SUCCESSFULLY_DESCRIPTION { get; set; }

        public string REASON { get; set; }

        public int? TASK_ID_HH { get; set; }

        public int? IN_PLAN_ROUTE { get; set; }

        public string CREATE_BY { get; set; }

        public DateTime START_DATE { get; set; }

        public DateTime END_DATE { get; set; }

        public string TASK_TYPE_DESCIPTION { get; set; }

        public float LAPSE_TIME { get; set; }

        public decimal TOTAL_AMOUNT { get; set; }

        public string LOGIN { get; set; }
    }
}
