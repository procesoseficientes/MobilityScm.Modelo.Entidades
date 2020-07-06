using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class TransferenciaEncabezado
    {
        public decimal TRANSFER_ID { get; set; }

        public string SELLER_CODE { get; set; }

        public string SELLER_NAME { get; set; }

        public string SELLER_ROUTE { get; set; }

        public string NAME_ROUTE { get; set; }

        public string CODE_WAREHOUSE_SOURCE { get; set; }

        public string NAME_WAREHOUSE_SOURCE { get; set; }

        public string CODE_WAREHOUSE_TARGET { get; set; }

        public string NAME_WAREHOUSE_TARGET { get; set; }

        public string STATUS { get; set; }

        public DateTime LAST_UPDATE { get; set; }

        public string LAST_UPDATE_BY { get; set; }

        public string COMMENT { get; set; }

        public int? IS_ONLINE { get; set; }

        public string IS_ONLINE_DESCRIPTION { get; set; }

        public IList<TransferenciaDetalle> Detalles { get; set; }

        public string CODE_BROADCAST { get; set; }

        public DateTime CREATION_DATE { get; set; }
    }
}
