using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class BodegaConAccesoPorUsuario
    {
        public int USER_CORRELATIVE { get; set; }

        public string CODE_WAREHOUSE { get; set; }

        public string DESCRIPTION_WAREHOUSE { get; set; }
    }
}
