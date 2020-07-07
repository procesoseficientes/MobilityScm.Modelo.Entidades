using System;
using MobilityScm.Modelo.Entidades;

namespace MobilityScm.Modelo.Argumentos
{
    public class PaginaArgumento : EventArgs
    {
        public Pagina Data { get; set; }
        public Encuesta Encuesta { get; set; }
    }
}