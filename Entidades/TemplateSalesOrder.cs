using MobilityScm.Modelo.Tipos;

namespace MobilityScm.Modelo.Entidades
{
    public class TemplateSalesOrder
    {
        public ResultadoOperacionTipo Resultado { get; set; }
        public string DbData { get; set; }

        private object _dato;
        public object Dato
        {
            get { return _dato; }
            set
            {
                DbData = null;
                _dato = new object();
                _dato = value;
            }
        }

        public T ObtenerDato<T>()
        {
            return (T)(DbData ?? _dato);
        }

    }
}