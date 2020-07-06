using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class EstadoDeCuentaEncabezado
    {
        public string CODE_CUSTOMER { get; set; }
        public string NAME_CUSTOMER { get; set; }
        public decimal CREDIT_LIMIT { get; set; }
        public decimal AVAILABLE_CREDIT { get; set; }
        public decimal TOTAL_CREDIT { get; set; }
        public decimal PAID_TO_DATE { get; set; }
        public int EXTRA_DAYS { get; set; }
        public int QTY_OVERDUE_INVOICE { get; set; }
    }
}
