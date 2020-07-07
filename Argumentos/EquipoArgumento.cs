using System;
using System.Collections.Generic;
using MobilityScm.Modelo.Entidades;

namespace MobilityScm.Modelo.Argumentos
{

    public class EquipoArgumento : EventArgs
    {
        public Equipo Equipo { get; set; }

        public string Login_Id { get; set; }

        public string Xml { get; set; }

        public List<Usuario> Usuarios { get; set; }
    }
}
