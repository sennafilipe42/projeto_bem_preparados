using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace Api.Data
{
    public class RepositoryConnector
    {
        public IConfiguration _configuration;

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
