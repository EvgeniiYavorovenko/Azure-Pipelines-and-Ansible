using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;
using Microsoft.Extensions.Configuration;

namespace WebApplication2.Services
{
    public interface IGetKeyService
    {
        MyFullName GetFullName();
        ConnectionString GetConnectionString();
    }

    public class GetKeyService : IGetKeyService
    {
        private IConfiguration _configuration;
        public GetKeyService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public MyFullName GetFullName()
        {
            var response = new MyFullName
            {
                myFullName = _configuration.GetSection("MyFullName").Value
            };
            return response;
        }

        public ConnectionString GetConnectionString()
        {
            var response = new ConnectionString
            {
                connectionString = _configuration.GetConnectionString("DB")
            };
            return response;
        }
    }
}
