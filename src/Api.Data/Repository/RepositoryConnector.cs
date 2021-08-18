using Microsoft.Extensions.Configuration;

namespace Api.Data.Repository
{
    public class RepositoryConnector
    {
        public IConfiguration _configuration;

        //Injeção de dependencias
        public RepositoryConnector(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetConnection()
        {
            return _configuration.GetSection("Connections").GetSection("ConnectionStringUdemy").Value;
        }

    }
}
