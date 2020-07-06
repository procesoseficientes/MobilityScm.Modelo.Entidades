using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    /// <summary>
    /// Encabezado de la microencuesta
    /// </summary>
    [Serializable]
    public class MicroEncuestaEncabezado
    {
        /// <summary>
        /// Id de la microencuesta
        /// </summary>
        public int QUIZ_ID { get; set; }
        /// <summary>
        /// Nombre de la microencuesta
        /// </summary>
        public string NAME_QUIZ { get; set; }
        /// <summary>
        /// Fecha valida de inicio
        /// </summary>
        public DateTime VALID_START_DATETIME { get; set; }
        /// <summary>
        /// Fecha valida de finalizacion 
        /// </summary>
        public DateTime VALID_END_DATETIME { get; set; }
        /// <summary>
        /// Orden 
        /// </summary>
        public int ORDER { get; set; }
        /// <summary>
        /// La microencuesta es obligatoria
        /// </summary>
        public int REQUIRED { get; set; }
        /// <summary>
        /// la microencuesta se ejecuta al finalizar o al iniciar ruta
        /// </summary>
        public int QUIZ_START { get; set; }
        /// <summary>
        /// Ultima actualizacion 
        /// </summary>
        public DateTime? LAST_UPDATE { get; set; }
        /// <summary>
        /// Ultimo usuario en actualizar 
        /// </summary>
        public string LAST_UPDATE_BY { get; set; }
        /// <summary>
        /// Descripcion 
        /// </summary>
        public string DESCRIPTION_REQUIRED { get; set; }
        /// <summary>
        /// Descripcion 
        /// </summary>
        public string DESCRIPTION_QUIZ_START { get; set; }
        /// <summary>
        /// codigo de ruta
        /// </summary>
        public string ROUTE_CODE { get; set; }
        /// <summary>
        /// codigo de canal
        /// </summary>
        public string CODE_CHANNEL { get; set; }

    }
}
