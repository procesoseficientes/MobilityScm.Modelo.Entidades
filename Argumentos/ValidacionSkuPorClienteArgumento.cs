using System;
using System.Collections.Generic;
using MobilityScm.Modelo.Entidades;

namespace MobilityScm.Modelo.Argumentos
{
    public class ValidacionSkuPorClienteArgumento:EventArgs
    {
        public List<OrdenDeVentaExcel> OrdenDeVentaDetallesExcel{ get; set; }
        public string IdCliente { get; set; }
        public string FechaEntrega { get; set; }

        public string IdListaDePrecios { get; set; }

        public string login { get; set; }

    }
}