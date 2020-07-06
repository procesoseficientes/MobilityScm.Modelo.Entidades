using System;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class Error
    {
        public string ERROR { get; set; }

        public int LINEA { get; set; }
    }
}