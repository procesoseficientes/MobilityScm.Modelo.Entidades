using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class Vehiculo
    {
        public string CODE_VEHICLE { get; set; }

        public string PLATE_VEHICLE { get; set; }

        public string BRAND { get; set; }
        

    }
}
