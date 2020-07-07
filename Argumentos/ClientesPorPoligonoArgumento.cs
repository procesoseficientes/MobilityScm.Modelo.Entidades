using System;
using MobilityScm.Modelo.Entidades;

namespace MobilityScm.Modelo.Argumentos
{
    public class ClientesPorPoligonoArgumento : EventArgs
    {
        public ClientesPorPoligono ClientesPorPoligono { get; set; }
    }
}