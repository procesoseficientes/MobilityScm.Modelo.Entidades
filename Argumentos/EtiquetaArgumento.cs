using System;
using MobilityScm.Modelo.Entidades;


namespace MobilityScm.Modelo.Argumentos
{
    public class EtiquetaArgumento : EventArgs
    {
        public Etiqueta Data { get; set; }

        public int CUSTOMER { get; set; }
    }
}
