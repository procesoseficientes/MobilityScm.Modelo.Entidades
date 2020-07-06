using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class PickingDetalle
    {
        public int PICKING_DETAIL { get; set; }

        public int PICKING_HEADER { get; set; }

        public string CODE_SKU { get; set; }

        public string DESCRIPTION_SKU { get; set; }

        public float DISPATCH { get; set; }

        public float SCANNED { get; set; }

        public float RESULT { get; set; }

        public string COMMENTS { get; set; }

        public DateTime LAST_UPDATE { get; set; }

        public string LAST_UPDATE_BY { get; set; }

        public float DIFFERENCE { get; set; }

        public float QUANTITY { get; set; }
    }
}
