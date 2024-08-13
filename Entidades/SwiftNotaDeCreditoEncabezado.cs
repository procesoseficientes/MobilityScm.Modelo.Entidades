using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class SwiftNotaDeCreditoEncabezado
    {
        public int ERP_RECEPTION_DOCUMENT_HEADER_ID { get; set; }
        public int DOC_ENTRY { get; set; }
        public int DOC_NUM { get; set; }
        public string SOURCE { get; set; }
        public string CLIENT_CODE { get; set; }
        public string CLIENT_NAME { get; set; }
        public int SERIE { get; set; }
        public string DOC_TYPE { get; set; }
        public string ADDRESS { get; set; }
        public string COMMENTS { get; set; }
        public int SLP_CODE { get; set; }
        public string DATA_SOURCE { get; set; }
        public string CURRENCY { get; set; }
        public decimal DOC_RATE { get; set; }
        public string SUBSIDIARY { get; set; }
        public SwiftNotaDeCreditoDetalle[] Detalle { get; set; }
    }
}
