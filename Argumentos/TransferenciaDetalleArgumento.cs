using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MobilityScm.Modelo.Entidades;

namespace MobilityScm.Modelo.Argumentos
{
    public class TransferenciaDetalleArgumento : EventArgs
    {
        public TransferenciaDetalle Data { get; set; }

        public TransferenciaEncabezado DataTransferenciaEncabezado  { get; set; }

        public IList<TransferenciaEncabezado> ListadoDeTransferenciaEncabezados { get; set; }
    }
}
