using System;
using System.Collections.Generic;
using MobilityScm.Modelo.Entidades;
using System.Collections.Generic;

namespace MobilityScm.Modelo.Argumentos
{
    public class AcuerdoComercialArgumento : EventArgs
    {
        public AcuerdoComercial AcuerdoComercial { get; set; }

        public Cliente Cliente { get; set; }

        public DescuentoDeAcuerdoComercial DescuentoDeAcuerdoComercial { get; set; }

        public List<DescuentoDeAcuerdoComercial> ListaDeDescuentoDeAcuerdoComercial { get; set; }

        public List<AcuerdoComercial> AcuerdosComerciales { get; set; }

        public List<Canal> Canales { get; set; }

        public List<Bonificacion> Bonificaciones { get; set; }

        public Bonificacion Bonificacion { get; set; }

        public BonificacionPorMultiplo BonificacionPorMultiplo { get; set; }

        public List<BonificacionPorMultiplo> BonificacionesPorMultiplo { get; set; }

        public IList<VentaPorMultiplo> VentasPorMultiplo { get; set; }

        public ReglaDeBonificacionDeCombo ReglaDeBonificacionDeCombo { get; set; }

        public IList<ReglaDeBonificacionDeCombo> ReglasDeBonificacionDeCombos { get; set; }

        public IList<BonificacionPorCombo> BonificacionPorCombos { get; set; }

        public DescuentoPorMontoGeneral DescuentoPorMontoGeneral { get; set; }

        public IList<DescuentoPorMontoGeneral> DescuentosPorMontoGeneral { get; set; }
    }
}
