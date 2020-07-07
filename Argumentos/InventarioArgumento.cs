
using System;
using System.Collections.Generic;
using MobilityScm.Modelo.Entidades;

namespace MobilityScm.Modelo.Argumentos
{
    public class InventarioArgumento : EventArgs
    {
        public Inventario Data { get; set; }

        public Bodega DataBodega { get; set; }

        public Ubicacion DataUbicacion { get; set; }

        public Reubicacion DataReubicacion { get; set; }

        public IList<Inventario> ListaInventario { get; set; }

        public IList<OrdenDeVentaEncabezado> OrdenDeVentaEncabezados { get; set; }
    }
}
