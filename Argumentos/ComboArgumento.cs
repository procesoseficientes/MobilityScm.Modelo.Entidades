using System;
using System.Collections.Generic;
using MobilityScm.Modelo.Entidades;

namespace MobilityScm.Modelo.Argumentos
{
    public class ComboArgumento : EventArgs
    {
        public Combo Combo { get; set; }

        public IList<SkuPorCombo> ProductosDeComboQueCambiaron { get; set; }
    }
}