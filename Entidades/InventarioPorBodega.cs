using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class InventarioPorBodega
    {
        public string SKU { get; set; }

        public string DESCRIPTION_SKU { get; set; }

        public string BARCODE { get; set; }

        public float ON_HAND { get; set; }

        public string WAREHOUSE { get; set; }

        public float QTY { get; set; }

        public string HANDLE_SERIAL_NUMBER { get; set;}
    }
}
