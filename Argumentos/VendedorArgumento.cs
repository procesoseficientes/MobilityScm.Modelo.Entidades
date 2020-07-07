using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MobilityScm.Modelo.Entidades;

namespace MobilityScm.Modelo.Argumentos
{
    public class VendedorArgumento : EventArgs
    {
        public Vendedor Data { get; set; }
    }
}
