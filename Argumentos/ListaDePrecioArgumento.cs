using System;
using MobilityScm.Modelo.Entidades;

namespace MobilityScm.Modelo.Argumentos
{
    public class ListaDePrecioArgumento : EventArgs
    {
        public ListaDePrecio Data { get; set; }
    }
}