using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    /// <summary>
    /// Objeto Respuesta con sus propiedades 
    /// </summary>
    [Serializable]
    public class Respuesta
    {
        /// <summary>
        /// Id de respuesta 
        /// </summary>
        public int ANSWER_ID { get; set; }
        /// <summary>
        /// Id de pregunta 
        /// </summary>
        public int QUESTION_ID { get; set; }
        /// <summary>
        /// Pregunta 
        /// </summary>
        public string QUESTION { get; set; }
        /// <summary>
        /// respuesta
        /// </summary>
        public string ANSWER { get; set; }
        /// <summary>
        /// Ultima actualizacion 
        /// </summary>
        public DateTime? LAST_UPDATE { get; set; }
        /// <summary>
        /// Ultimo usuario en actualizar
        /// </summary>
        public string LAST_UPDATE_BY { get; set; }
    } 
}
