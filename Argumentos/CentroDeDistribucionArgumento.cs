using MobilityScm.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Argumentos
{
    public class CentroDeDistribucionArgumento: EventArgs
    {
        public CentroDeDistribucion CentroDeDistribucion { get; set; }

        public string LOGIN { get; set; }

        public Bodega Bodega { get; set; }
    }
}
