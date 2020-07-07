using System;
using MobilityScm.Modelo.Entidades;

namespace MobilityScm.Modelo.Argumentos
{
    public class EncuestaArgumento: EventArgs
    {
        public Encuesta Data { get; set; }
    }
}
