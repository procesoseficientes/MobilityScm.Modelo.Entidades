using System;

namespace MobilityScm.Modelo.Entidades
{
    public class DevolucionDeInventarioEncabezado
    {
        public int DEVOLUTION_ID { get; set; }

        public string CODE_CUSTOMER { get; set; }

        public string DOC_SERIE { get; set; }

        public int DOC_NUM { get; set; }

        public string CODE_ROUTE { get; set; }

        public string GPS_URL { get; set; }

        public DateTime? POSTED_DATETIME { get; set; }

        public string POSTED_BY { get; set; }

        public DateTime? LAST_UPDATE { get; set; }

        public string LAST_UPDATE_BY { get; set; }

        public decimal? TOTAL_AMOUNT { get; set; }

        public int? IS_POSTED { get; set; }

        public string IMG_1 { get; set; }

        public string IMG_2 { get; set; }

        public string IMG_3 { get; set; }

    }
}