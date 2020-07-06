using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    /// <summary>
    /// Entidad para representar la asociación de un poligono por cliente.
    /// </summary>
    [Serializable]
    public class PoligonoPorCliente
    {
        /// <summary>
        /// Identificador del poligono
        /// </summary>
        public int POLYGON_ID { get; set; }

        /// <summary>
        /// código de cliente
        /// </summary>
        public string CODE_CUSTOMER { get; set; }

        /// <summary>
        /// Es nuevo el cliente
        /// </summary>
        public int? IS_NEW { get; set; }

        /// <summary>
        /// Tiene propuesta
        /// </summary>
        public int? HAS_PROPOSAL { get; set; }

        /// <summary>
        /// Tiene frecuencia
        /// </summary>
        public int? HAS_FREQUENCY { get; set; }
    }
}
