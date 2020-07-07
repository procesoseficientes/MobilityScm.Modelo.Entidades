using System;
using System.Collections.Generic;
using MobilityScm.Modelo.Entidades;

namespace MobilityScm.Modelo.Argumentos
{
    public class ClienteConCambiosArgumento : EventArgs
    {
        public ClienteConCambios Data { get; set; }

        public IList<ClienteConCambios> ClientesConCambios { get; set; }

        public DateTime START_DATE { get; set; }

        public DateTime END_DATE { get; set; }

        public string LOGIN { get; set; }

        public Etiqueta Etiqueta { get; set; }
    }
}
