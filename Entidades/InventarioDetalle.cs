using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    public class InventarioDetalle
    {
        public decimal? Quantity { get; set; }

        public string ItemCode { get; set; }

        public int LineNum { get; set; }

        public string WarehouseCode { get; set; }

        public string Ref2 { get; set; }

        public double Price { get; set; }
    }
}
