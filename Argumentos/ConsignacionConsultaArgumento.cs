using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MobilityScm.Modelo.Entidades;

namespace MobilityScm.Modelo.Argumentos
{
    public class ConsignacionConsultaArgumento : EventArgs
    {
        public ConsignacionEncabezado Data { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFinal { get; set; }
    }
}
