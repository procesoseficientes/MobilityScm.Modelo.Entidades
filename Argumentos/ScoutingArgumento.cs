using System;
using MobilityScm.Modelo.Entidades;

namespace MobilityScm.Modelo.Argumentos
{
    public class ScoutingArgumento:EventArgs
    {
        public Cliente Cliente { get; set; }
        public ClienteDetalle ClienteDetalle { get; set; }
        public Pais Pais { get; set; }
        public Departamento Departamento { get; set; }

        public Scouting Scouting { get; set; }

        public Etiqueta Etiqueta { get; set; }
        public DatosAdicionalesDeScouting DatosAdicionalesDeScouting { get; set; }

        public FrecuenciaDeCliente FrecuenciaDeCliente { get; set; }
    }
}