using System;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class LocalizacionGeografica
    {
        public string PAIS { get; set; }

        public string DEPARTAMENTO { get; set; }

        public string MUNICIPIO { get; set; }
    }
}