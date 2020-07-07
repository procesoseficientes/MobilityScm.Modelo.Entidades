using System;
using MobilityScm.Modelo.Entidades;

namespace MobilityScm.Modelo.Argumentos
{
    public class OrdenVentaArgumento : EventArgs
    {
        public OrdenDeVentaEncabezado Data { get; set; }

        public Parametro Parametro { get; set; }

        public OrdenDeVentaConDetalle OrdenDeVentaConDetalle { get; set; }


    }
}
