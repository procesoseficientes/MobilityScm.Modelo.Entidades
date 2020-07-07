using System;
using MobilityScm.Modelo.Entidades;
using System.Collections.Generic;

namespace MobilityScm.Modelo.Argumentos
{
    public class BodegaConAccesoPorUsuarioArgumento : EventArgs
    {
        public BodegaConAccesoPorUsuario data { get; set; }

        public IList<BodegaConAccesoPorUsuario> ListaBodegaConAccesoPorUsuario { get; set; }
    }
}
