using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MobilityScm.Modelo.Entidades;

namespace MobilityScm.Modelo.Argumentos
{
    public class TransferenciaEncabezadoArgumento : EventArgs
    {
        public TransferenciaEncabezado Data { get; set; }
        
    }
}
