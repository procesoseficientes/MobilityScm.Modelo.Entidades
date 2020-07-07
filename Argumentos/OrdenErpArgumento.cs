using System;
using MobilityScm.Modelo.Entidades;

namespace MobilityScm.Modelo.Argumentos
{
    public class OrdenErpArgumento : EventArgs
    {
        public OrdenEncabezadoErp OrdenEncabezadoErp { get; set; }
    }
}
