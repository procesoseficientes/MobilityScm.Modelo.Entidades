using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    /// <summary>
    /// Clase para realizar una carga externa de manifiestos de carga.
    /// </summary>
    [Serializable]
    public class CargaManifiesto
    {
        /// <summary>
        /// Número de documento
        /// </summary>
        public string NumeroDocumento { get; set; }

        /// <summary>
        /// Código cliente
        /// </summary>
        public string CodigoCliente { get; set; }

        /// <summary>
        /// Código cliente
        /// </summary>
        public string NombreCliente { get; set; }

        /// <summary>
        /// Direccion de Cliente
        /// </summary>
        public string DireccionCliente { get; set; }

        /// <summary>
        /// Gps del cliente
        /// </summary>
        public string GPSCliente { get; set; }

        /// <summary>
        /// Fecha Visita 
        /// </summary>
        public DateTime FechaVisita { get; set; }

        /// <summary>
        /// Hora de vista
        /// </summary>
        public TimeSpan HoraRecomendadaVisita { get; set; }

        /// <summary>
        /// Comentario
        /// </summary>
        public string Comentario { get; set; }

        /// <summary>
        /// Código de producto
        /// </summary>
        public string CodigoSKU { get; set; }

        /// <summary>
        /// Nombre de sku
        /// </summary>
        public string NombreSKU { get; set; }

        /// <summary>
        /// Cantidad
        /// </summary>
        public double Cantidad { get; set; }
    }
}
