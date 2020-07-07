using MobilityScm.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilityScm.Modelo.Argumentos
{
   public  class DemoArgumento: EventArgs
    {
        public Demo Data { get; set; }
    }
}
