using Microsoft.Extensions.Configuration;

namespace LoshkaDAL.Data
{
    public class DatabaseConfiguration(IConfiguration configuration)
    {
        private readonly IConfiguration _configuration = configuration;

        public string ConnectionString => _configuration.GetConnectionString("DefaultConnection");
    }
}
