using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MobilityScm.Modelo.Entidades;

namespace MobilityScm.Modelo.Argumentos
{
    
    public class VehiculoArgumento: EventArgs
    {
       public Vehiculo Vehiculo { get; set; }

        public IList<Usuario> ListaVendedores { get; set; }

    }
}
