using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    public class TransaccionInventario
    {
        public string DocNum{ get; set; }
        public string SeriesEntrada { get; set; }
        public string SeriesSalida { get; set; }
        public DateTime DocDate { get; set; }
        public DateTime TaxDate { get; set; }
        public string Ref2 { get; set; }
        public string PriceList { get; set; }
        public string CardCode { get; set; }
        public string CardName { get; set; }

        public List<InventarioDetalle> Detalle { get; set; }
    }
}
