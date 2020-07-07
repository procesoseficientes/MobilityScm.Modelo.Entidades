using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MobilityScm.Modelo.Entidades;

namespace MobilityScm.Modelo.Argumentos
{
    public class RecibosEmitidosArgumento: EventArgs
    {
        public RecibosEmitidos RecibosEmitidos { get; set; }
        public FacturasPagadasPorRecibo FacturasPagadasPorRecibo { get; set; }
        public TiposDePagoPorRecibo TiposDePagoPorRecibo { get; set; }
        public string Login_Id { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }

    }
}
