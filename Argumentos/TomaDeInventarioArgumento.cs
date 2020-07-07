using System;
using MobilityScm.Modelo.Entidades;

namespace MobilityScm.Modelo.Argumentos
{
    public class TomaDeInventarioArgumento : EventArgs
    {
        public TomaDeInventario TomaDeInventario { get; set; }
    }
}
