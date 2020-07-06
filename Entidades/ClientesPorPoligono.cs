using System;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class ClientesPorPoligono
    {
        public string SELLER_CODE { get; set; }

        public string SELLER_NAME { get; set; }

        public string CODE_ROUTE  { get; set; }

        public string NAME_ROUTE { get; set; }

        public int POLYGON_ID_REGION { get; set; }

        public string POLYGON_NAME_REGION { get; set; }

        public int POLYGON_ID_SECTOR { get; set; }

        public string POLYGON_NAME_SECTOR { get; set; }

        public int POLYGON_ID { get; set; }

        public string POLYGON_NAME { get; set; }

        public string POLYGON_TYPE { get; set; }

        public string TYPE_TASK { get; set; }

        public int FREQUENCY_WEEKS { get; set; }

        public int SUNDAY { get; set; }

        public int MONDAY { get; set; }

        public int TUESDAY { get; set; }

        public int WEDNESDAY { get; set; }

        public int THURSDAY { get; set; }

        public int FRIDAY { get; set; }

        public int SATURDAY { get; set; }

        public string LOGIN { get; set; }

        public int DAY { get; set; }
    }
}