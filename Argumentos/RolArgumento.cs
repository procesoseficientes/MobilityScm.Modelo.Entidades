using System;
using System.Collections.Generic;
using MobilityScm.Modelo.Entidades;

namespace MobilityScm.Modelo.Argumentos
{
    public class RolArgumento:EventArgs
    {
        public Rol Data { get; set; }
        public IList<Privilegios> Privilegios { get; set; }
    }
}