using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Partys.DomainObjects;

namespace Partys.WebService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PartysController : ControllerBase
    {
        private readonly ILogger<PartysController> _logger;
     

       public PartysController(ILogger<PartysController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Party> GetRoute()
        {
            return new List<Party>() 
            { 
                new Party() 
                { 
                    Id = 1,
                    Time = "23:00",
                    Adress = "Парк ВДНХ",
                    Place = 
                    
                    {
                      //  Area = 1,
                      //  Name = "ГУП \"Мосгортранс\"",
                      //  TimeZone = "Europe/Moscow",
                        //WebSite = "https://data.mos.ru/opendata/7702155262-programma-kulturnyh-meropriyatiy-organizovannyh-pri-podderjke-pravitelstva-moskvy"
                    }
                } 
            };
        }
    }
}
