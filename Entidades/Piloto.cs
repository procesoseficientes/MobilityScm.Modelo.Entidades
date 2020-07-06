using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilityScm.Modelo.Entidades
{
    [Serializable]
    public class Piloto
    {

        public int DRIVER { get; set; }

        public string CODE_DRIVER { get; set; }

        public string NAME_DRIVER { get; set; }

        public string NAME_CLASSIFICATION { get; set; }

        public string LICENSE_DRIVER { get; set; }

        public string PHONE_DRIVER { get; set; }

        public string VALUE_TEXT_CLASSIFICATION { get; set; }

    }
}
