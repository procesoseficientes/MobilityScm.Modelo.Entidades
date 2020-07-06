using System;
using System.Collections.Generic;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class Poligono
    {
        public int? POLYGON_ID { get; set; }

        public string POLYGON_NAME { get; set; }

        public string POLYGON_DESCRIPTION { get; set; }

        public string COMMENT { get; set; }

        public string LAST_UPDATE_BY { get; set; }

        public DateTime LAST_UPDATE_DATETIME { get; set; }

        public int? POLYGON_ID_PARENT { get; set; }

        public string POLYGON_TYPE { get; set; }

        public string SUB_TYPE { get; set; }

        public int CUSTOMERS_COUNT { get; set; }
        public decimal CUSTOMERS_PERCENT { get; set; }

        public string PARENT_NAME { get; set; }

        public string POLYGON_NAME_PARENT { get; set; }

        public int HAS_CHILD { get; set; }
        public string HAS_CHILD_MESSAGE { get; set; }

        public string TYPE_TASK { get; set; }

        public int? SAVE_ROUTE { get; set; }

        public string TYPE_TASK_DESCRIPTION { get; set; }

        public IList<PoligonoPuntos> Puntos { get; set; }

        public string CODE_WAREHOUSE { get; set; }

        public string DESCRIPTION_WAREHOUSE { get; set; }

        public DateTime LAST_OPTIMIZATION { get; set; }

        public int? IS_MULTIPOLYGON { get; set; }

        public int OPTIMIZE { get; set; }

        public int? ROUTE_ID { get; set; }

        public int? ID_FREQUENCY { get; set; }

        public string SELLER_CODE { get; set; }

        public string SELLER_NAME { get; set; }

        public int?  IS_MODIFIABLE { get; set; }

        public int? AVAILABLE { get; set; }

        public decimal? TOTAL_SALES { get; set; }

        public decimal? TOTAL_SALES_PERCENT { get; set; }

        public string PACK_UNIT { get; set; }

        public decimal? QTY { get; set; }

        public string SECTOR { get; set; }

        public string REGION { get; set; }

        public string CODE_ROUTE { get; set; }

        public string NAME_ROUTE { get; set; }

        public int? IS_MULTISELLER { get; set; }
    }
}
