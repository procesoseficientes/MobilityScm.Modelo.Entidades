using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable()]
    public class Licencia
    {
        public int? ID { get; set; }
        public int? ENTERPRISE_ID{ get; set; }
        public int? LICENSE_TYPE_ID { get; set; }
        public int TOTAL_LICENSES { get; set; }
        public int LICENSES_IN_USE { get; set; }
        public int AVAILABLE_LICENSES { get; set; }
        public int ASSIGNATION_TYPE { get; set; }
        public int VALIDATION_TYPE { get; set; }
        public DateTime DATE_VALID_FROM { get; set; }
        public DateTime DATE_VALID_TO { get; set; }
        public string DATE_VALID_TO_STRING { get; set; }
        public string WATER_MARK { get; set; }
        public string INITIALIZATION_VECTOR { get; set; }
        public string KEY { get; set; }
        public int STATUS { get; set; }
        public DateTime DATE_MODIFIED { get; set; }
        public DateTime DATE_CREATED { get; set; }
        public string LAST_MODIFIED_BY  { get; set; }
        public int PRIORITY { get; set; }
        public string COMMUNICATION_ADDRESS { get; set; }
        public string APPLICATION_TYPE { get; set; }
        public string AUTENTICATION_TYPE { get; set; }
        public string LICENSE_STATUS { get; set; }
        public string ASSIGMENT_TYPE { get; set; }
        public int REMAINING_DAYS { get; set; }
    }
}
