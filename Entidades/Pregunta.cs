using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    /// <summary>
    /// Objeto pregunta con sus propiedades
    /// </summary>
    [Serializable]
    public class Pregunta
    {
        /// <summary>
        /// Id de pregunta 
        /// </summary>
        public int QUESTION_ID { get; set; }
        /// <summary>
        /// Id encuesta 
        /// </summary>
        public int QUIZ_ID { get; set; }
        /// <summary>
        /// Pregunta 
        /// </summary>
        public string QUESTION { get; set; }
        /// <summary>
        /// Order 
        /// </summary>
        public int ORDER { get; set; }
        /// <summary>
        /// Es pregunta obligatoria 
        /// </summary>
        public int REQUIRED { get; set; }
        /// <summary>
        /// Tipo de pregunta 
        /// </summary>
        public string TYPE_QUESTION { get; set; }
        /// <summary>
        /// Ultima actualizacion 
        /// </summary>
        public DateTime? LAST_UPDATE { get; set; }
        /// <summary>
        /// Ultimo usuario en actualizar 
        /// </summary>
        public string LAST_UPDATE_BY { get; set; }
        /// <summary>
        /// Es requerito 
        /// </summary>
        public string IS_REQUIRED { get; set; }
        /// <summary>
        /// Explicacion de tipo de pregunta para el grid
        /// </summary>
        public string TRANSLATE_TYPE_QUESTION { get; set; }

    }
}
