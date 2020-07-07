using System;
using MobilityScm.Modelo.Entidades;

namespace MobilityScm.Modelo.Argumentos
{
    public class TareaArgumento: EventArgs
    {
        public Tarea Data { get; set; }
    }
}
