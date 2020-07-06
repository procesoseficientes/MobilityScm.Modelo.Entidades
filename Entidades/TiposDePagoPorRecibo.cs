using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class TiposDePagoPorRecibo
    {
        public int? PAYMENT_HEADER_ID { get; set; }
        public string PAYMENT_TYPE { get; set; }

        public Decimal AMOUNT { get; set; }

        public string DOCUMENT_NUMBER { get; set; }

        public string BANK_NAME { get; set; }

        public string FRONT_IMAGE { get; set; }

        public string BACK_IMAGE { get; set; }
    }    
}
