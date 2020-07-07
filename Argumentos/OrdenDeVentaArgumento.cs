using System;
using MobilityScm.Modelo.Entidades;

namespace MobilityScm.Modelo.Argumentos
{
    public class OrdenDeVentaArgumento : ConsultaArgumento
    {
        public OrdenDeVentaEncabezado Data { get; set; }

        public OrdenDeVentaDetalle OrdenDeVentaDetalle { get; set; }

        public EstadoDeCuentaEncabezado EstadoDeCuentaEncabezado { get; set; }

        public EstadoDeCuentaDetalle EstadoDeCuentaDetalle { get; set; }

        public Usuario Usuario { get; set; }

        public OrdenDeVentaConDetalle OrdenDeVentaConDetalle { get; set; }
    }
}