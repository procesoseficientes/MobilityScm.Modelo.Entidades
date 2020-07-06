using MobilityScm.Modelo.Tipos;

namespace MobilityScm.Modelo.Entidades
{
    public class Operacion
    {
        public ResultadoOperacionTipo Resultado { get; set; }
        public string Mensaje { get; set; }
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

        public string DbData { get; set; }

        public T ObtenerDato<T>()
        {
            return (T)(DbData ?? _dato);
        }


        public int Codigo { get; set; }
    }
}
