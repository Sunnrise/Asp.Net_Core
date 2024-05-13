using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Data.SqlClient;

//C:\Users\{username}\AppData\Roaming\Microsoft\UserSecrets\{userSecretsId}\secrets.json
namespace SecretManagerTools.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        readonly IConfiguration configuration;
        public HomeController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public void Index()
        {
            var user=configuration["MailInfo:User"];
            var password = configuration["MailInfo:Password"];

            var connection = configuration.GetConnectionString("SQL");
            SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder(connection);
            sqlConnectionStringBuilder.UserID = configuration["SQL:UserName"];
            sqlConnectionStringBuilder.Password = configuration["SQL:Password"];
            connection = sqlConnectionStringBuilder.ConnectionString;
            Console.WriteLine();


        }
    }
}
