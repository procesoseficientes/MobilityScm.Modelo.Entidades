using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MobilityScm.Modelo.Entidades;

namespace MobilityScm.Modelo.Argumentos
{
    /// <summary>
    /// Agumento de Microencuesta
    /// </summary>
    public class MicroEncuestaArgumento : EventArgs
    {
        /// <summary>
        /// Microencuesta header 
        /// </summary>
        public MicroEncuestaEncabezado MicroEncuestaEncabezado  {get;set; }
        /// <summary>
        /// Propiedad Pregunta 
        /// </summary>
        public Pregunta Pregunta { get; set; }
        /// <summary>
        /// Propiedad Respuesta
        /// </summary>
        public Respuesta Respuesta { get; set; }
        /// <summary>
        /// Propiedad Asignacion 
        /// </summary>
        public AsignacionMicroencuesta Asignacion { get; set; }
        /// <summary>
        /// Propiedad Lista encuesta detalle 
        /// </summary>
        public IList<Pregunta> ListaEncuestaDetalle { get; set; }
        /// <summary>
        /// Propiedad Lista encuesta respuesta 
        /// </summary>
        public IList<Respuesta> ListaEncuestaRespuesta { get; set; }
        
        /// <summary>
        /// Routes to asign with the selected survey
        /// </summary>
        public IList<AsignacionMicroencuesta> RutasAAsignar { get; set; }

        /// <summary>
        /// Saves the xml string of routes to assign that will be send to SP on DataBase
        /// </summary>
        public string XmlRutasAAsignar { get; set; }

        /// <summary>
        /// Performs a call to method that updates some other site when a process is completed
        /// </summary>
        public Action<MicroEncuestaArgumento> CallbackAction { get; set; }

        /// <summary>
        /// Indicates if someone must use a CallbackAction method
        /// </summary>
        public bool UseCallbakAction { get; set ;} 
    }
}
