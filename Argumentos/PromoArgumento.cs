using System;
using System.Collections.Generic;
using MobilityScm.Modelo.Entidades;
using System.Collections.Generic;

namespace MobilityScm.Modelo.Argumentos
{
    public class PromoArgumento : EventArgs
    {
        public Promo Promo { get; set; }

        public BonoPorEscalaDePromo BonoPorEscalaDePromo { get; set; }

        public IList<BonoPorEscalaDePromo> BonificacionesPorEscala { get; set; }

        public BonoPorMultiploDePromo BonoPorMultiploDePromo { get; set; }

        public IList<BonoPorMultiploDePromo> BonificacionesPorMultiplo { get; set; }



        public ReglaDeBoniPorComboDePromo ReglaDeBonificacionPorComboDePromo { get; set; }

        public BonoPorComboDePromo BonoPorComboDePromo { get; set; }

        public IList<BonoPorComboDePromo> BonificacionesPorCombo { get; set; }

        public IList<BonificacionDeBonoPorComboDePromo> BonificacionesDeBonoPorCombo { get; set; }



        //================== Descuentos por escala ===============================
        /// <summary>
        /// DescuentoPorEscalaDePromo
        /// </summary>
        public DescuentoPorEscalaDePromo DescuentoPorEscalaDePromo { get; set; }

        /// <summary>
        /// DescuentosPorEscala
        /// </summary>
        public IList<DescuentoPorEscalaDePromo> DescuentosPorEscala { get; set; }


        //================= Descuentos por monto general ==========================
        /// <summary>
        /// DescuentoPorMontoGeneralDePromo
        /// </summary>
        public DescuentoPorMontoGeneralDePromo DescuentoPorMontoGeneralDePromo { get; set; }

        /// <summary>
        /// DescuentosPorMontoGeneral
        /// </summary>
        public IList<DescuentoPorMontoGeneralDePromo> DescuentosPorMontoGeneral { get; set; }

        //================= VENTA POR MULTIPLO ==============================================
        
        /// <summary>
        /// VentaPorMultiploDePromo
        /// </summary>
        public VentaPorMultiploDePromo VentaPorMultiploDePromo { get; set; }

        /// <summary>
        /// VentasPorMultiploDePromo
        /// </summary>
        public IList<VentaPorMultiploDePromo> VentasPorMultiploDePromo { get; set; }


        //================= Bonificacion por monto general ==========================
        /// <summary>
        /// BonoPorMontoGeneralDePromo
        /// </summary>
        public BonoPorMontoGeneralDePromo BonificacionPorMontoGeneralDePromo { get; set; }

        /// <summary>
        /// BonosPorMontoGeneral
        /// </summary>
        public IList<BonoPorMontoGeneralDePromo> BonificacionesPorMontoGeneral { get; set; }

        

        public IList<Promo> Promociones { get; set; }

        /// <summary>
        /// BonosPorMontoGeneral
        /// </summary>
        public IList<DescuentoPorMontoGeneralDePromo> ListaDeDescuentoPorMontoGeneral { get; set; }

        public string Xml { get; set; }

        public string LoginId { get; set; }

        //================= Promocion De Descuento Por Familia Por Tipo De Pago ==========================
        /// <summary>
        /// ListaDeDescuentoPorFamiliaPorTipoDePago
        /// </summary>
        public IList<DescuentoPorMontoGeneralDePromo> ListaDeDescuentoPorFamiliaPorTipoDePago { get; set; }

        //================= Promocion De Descuento Por precio especial ==========================
        /// <summary>
        /// ListaDeDescuentosPorPrecioEspecial
        /// </summary>
        public IList<DescuentosPorPrecioEspecial> ListaPrecioEspecial { get; set; }

        /// <summary>
        /// DescuentosPorPrecioEspecial
        /// </summary>
        public DescuentosPorPrecioEspecial DescuentoPorPrecioEspecial { get; set; }

    }
}
