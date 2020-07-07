using System;
using System.Collections.Generic;
using MobilityScm.Modelo.Entidades;

namespace MobilityScm.Modelo.Argumentos
{
    public class ClienteArgumento : EventArgs
    {
        public Cliente Data { get; set; }

        public IList<Cliente> Clientes { get; set; }
    }
}