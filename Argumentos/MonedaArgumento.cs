using System;
using MobilityScm.Modelo.Entidades;

namespace MobilityScm.Modelo.Argumentos
{
    public class MonedaArgumento: EventArgs
    {
        public Moneda Moneda { get; set; }
    }
}
