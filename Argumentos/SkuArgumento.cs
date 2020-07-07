using System;
using MobilityScm.Modelo.Entidades;

namespace MobilityScm.Modelo.Argumentos
{
    public class SkuArgumento : EventArgs
    {
        public Sku Data { get; set; }

    }
}