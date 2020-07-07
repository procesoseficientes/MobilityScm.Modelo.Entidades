using MobilityScm.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace MobilityScm.Modelo.Argumentos
{
    public class AdministrarLicenciasArgumento : EventArgs
    {
        public Logs log { get; set; }
        public Licencia licencia { get; set; }
        
        public Usuario usuario { get; set; }
        public int LICENSES_TO_DELETE { get; set; }
        public string XML_LOGS { get; set; }
        public int ID_LICENSE { get; set; }
        public string LOGIN { get; set; }
        public List<Usuario> ListaUsuarios { get; set; }
    }
}
