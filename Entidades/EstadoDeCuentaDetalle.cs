using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class EstadoDeCuentaDetalle
    {
        public int DOC_NUM { get; set; }

        public DateTime DOC_DUE_DATE { get; set; }

        public int OVERDUE_DAYS { get; set; }

        public decimal DOC_TOTAL { get; set; }

        public decimal PAID_TO_DATE { get; set; }

        public string CODE_CUSTOMER { get; set; }

        public DateTime DOC_DATE { get; set; }           
    }
}
