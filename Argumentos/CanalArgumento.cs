using System;
using MobilityScm.Modelo.Entidades;
using System.Collections.Generic;

namespace MobilityScm.Modelo.Argumentos
{
    public class CanalArgumento: EventArgs
    {
        public Canal Data { get; set; }
        public IList<Canal> ClientesAOperar { get; set; }
    }
}