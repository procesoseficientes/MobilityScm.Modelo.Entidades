using System;
using MobilityScm.Modelo.Entidades;

namespace MobilityScm.Modelo.Argumentos
{
    public class DevolucionDeInventarioArgumento :ConsultaArgumento
    {
        public DevolucionDeInventarioEncabezado DevolucionDeInventarioEncabezado { get; set; }
    }
}