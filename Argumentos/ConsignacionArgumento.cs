using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MobilityScm.Modelo.Entidades;

namespace MobilityScm.Modelo.Argumentos
{
    public class ConsignacionArgumento : EventArgs
    {
        public ConsignacionEncabezado Data { get; set; }

        public string FechaInicio { get; set; }
        
        public string FechaFinal { get; set; }

        public string Cantidad { get; set; }
    }
}
