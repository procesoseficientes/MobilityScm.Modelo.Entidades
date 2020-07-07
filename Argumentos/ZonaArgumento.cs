using MobilityScm.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Argumentos
{
    /// <summary>
    /// Argumento de zona
    /// </summary>
   public  class ZonaArgumento: EventArgs
    {
        /// <summary>
        /// Zona
        /// </summary>
        public Zona Zona { get; set; }

        /// <summary>
        /// Bodega por zona
        /// </summary>
        public BodegasPorZona BodegaPorZona{ get; set; }

        /// <summary>
        /// Listado de bodegas 
        /// </summary>
        public IList<BodegasPorZona> ListadoBodegas { get; set; }
    }
}
