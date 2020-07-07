using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MobilityScm.Modelo.Entidades;

namespace MobilityScm.Modelo.Argumentos
{
    public class RutaArgumento : EventArgs
    {
        public Ruta Data { get; set; }
        public Usuario Usuario { get; set; }
    }
}
