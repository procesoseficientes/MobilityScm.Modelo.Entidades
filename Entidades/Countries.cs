using System;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class Countries: ICountries
    {
        public string CODE_COUNTRY { get; set; }

        public string DESCRIPTION_COUNTRY { get; set; }
    }
}
