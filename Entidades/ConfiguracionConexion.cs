
using System.Configuration;

namespace MobilityScm.Modelo.Entidades
{
    public class ConfiguracionConexionSwift : IConfiguracionConexion
    {
        public string CadenaConexion => @"SWIFT_EXPRESSConnection";

        public string Esquema => ConfigurationManager.AppSettings.Get("Squema");
    }

    public class ConfiguracionConexion3PL : IConfiguracionConexion
    {
        public string CadenaConexion => @"3PLConnection";

        public string Esquema => ConfigurationManager.AppSettings.Get("Squema");
    }

    public interface IConfiguracionConexion
    {
        string CadenaConexion { get;  }

        string Esquema { get; }
    }
}
