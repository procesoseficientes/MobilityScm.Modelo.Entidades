using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    /// <summary>
    /// Argumento para obtener las rutas sin asignar y asignadas para su uso. 
    /// </summary>
    [Serializable]
    public class AsignacionMicroencuesta
    {
        /// <summary>
        /// Codigo de ruta 
        /// </summary>
        public string CODE_ROUTE { get; set; }
        /// <summary>
        /// Nombre de ruta
        /// </summary>
        public string NAME_ROUTE { get; set; }
        /// <summary>
        /// Id Usuario
        /// </summary>
        public int CORRELATIVE { get; set; }
        /// <summary>
        /// Nombre del usuario
        /// </summary>
        public string NAME_USER { get; set; }
        /// <summary>
        /// Login asociado al usuario
        /// </summary>
        public string LOGIN { get; set; }
        /// <summary>
        /// Nombre del equipo asociado al usuario
        /// </summary>
        public string TEAM_NAME { get; set; }
        /// <summary>
        /// Pregunta 
        /// </summary>
        public string ANSWER { get; set; }
        /// <summary>
        /// Id de microencuesta
        /// </summary>
        public int QUIZ_ID { get; set; }
        /// <summary>
        /// Pregunta 
        /// </summary>
        public string CODE_CHANNEL { get; set; }

    }
}
