using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class Logs{
        public int LOG_ID { get; set; }
        public DateTime LOG_DATETIME { get; set; }
        public string CODE_ROUTE { get; set; }
        public string LOGIN { get; set; }
        public string SOURCE_ERROR { get; set; }
        public string DOC_RESOLUTION { get; set; }
        public string DOC_SERIE { get; set; }
        public string MESSAGE_ERROR { get; set; }
        public string TYPE { get; set; }
    }
}
