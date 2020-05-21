using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    public class GetKeyController : PageModel
    {
        private IGetKeyService _getKeyService;
        public GetKeyController(IGetKeyService getKeyService)
        {
            _getKeyService = getKeyService;
        }

        public string GetMyFullName()
        {
            var response = _getKeyService.GetFullName().myFullName;
            return response;
        }

        public string GetConnectionString()
        {
            var response = _getKeyService.GetConnectionString().connectionString;
            return response;
        }
    }
}