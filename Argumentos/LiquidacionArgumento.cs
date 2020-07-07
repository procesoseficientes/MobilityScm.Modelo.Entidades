

using MobilityScm.Modelo.Entidades;

namespace MobilityScm.Modelo.Argumentos
{/// <summary>
    /// Liquidación argumento
    /// </summary>
    public class LiquidacionArgumento : ConsultaArgumento
    {
        /// <summary>
        /// Liquidación
        /// </summary>
        public Liquidacion Liquidacion { get; set; }

        /// <summary>
        /// Resumen Liquidación
        /// </summary>
        public ResumenLiquidacion ResumenLiquidacion { get; set; }
    }
}
