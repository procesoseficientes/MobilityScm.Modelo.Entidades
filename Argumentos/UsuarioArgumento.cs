using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MobilityScm.Modelo.Entidades;

namespace MobilityScm.Modelo.Argumentos
{
   public class UsuarioArgumento: EventArgs
    {
        public Usuario Usuario { set; get; }

        public Usuario Data { get; set; }

        public IList<Bodega> Bodegas { get; set; }
    }
}
    