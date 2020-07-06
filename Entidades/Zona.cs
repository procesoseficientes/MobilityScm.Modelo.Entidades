using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    /// <summary>
    /// clase zona
    /// </summary>
    public class Zona
    {
        /// <summary>
        /// Identificador de zona
        /// </summary>
        public int ZONE_ID { get; set; }

        /// <summary>
        /// Código de la zona 
        /// </summary>
        public string CODE_ZONE { get; set; }

        /// <summary>
        /// Descripción de la zona 
        /// </summary>
        public string DESCRIPTION_ZONE { get; set; }

        /// <summary>
        /// Ultima actualización 
        /// </summary>
        public string LAST_UPDATED_BY { get; set; }

        /// <summary>
        /// Fecha ultima actualización 
        /// </summary>
        public DateTime LAST_UPDATE { get; set; }
    }
}
