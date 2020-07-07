using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MobilityScm.Modelo.Entidades;

namespace MobilityScm.Modelo.Argumentos
{
    /// <summary>
    /// 
    /// </summary>
    public class OficinaDeVentaArgumento:EventArgs
    {
        /// <summary>
        /// 
        /// </summary>
        public OrganizacionDeVentas OrganizacionDeVentas { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public OficinaDeVenta OficinaDeVenta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IList<Vendedor> Vendedores { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Vendedor Vendedor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IList<Bodega> Bodegas { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Bodega Bodega { get; set; }

    }
}
