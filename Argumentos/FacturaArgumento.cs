using System;
using System.Collections.Generic;
using MobilityScm.Modelo.Entidades;

namespace MobilityScm.Modelo.Argumentos
{
    public class FacturaArgumento: ConsultaArgumento
    {
        public FacturaEncabezado Data { get; set; }

        public List<FacturaEncabezado> ListaDeFacturasEncabezado { get; set; }
    }
}
