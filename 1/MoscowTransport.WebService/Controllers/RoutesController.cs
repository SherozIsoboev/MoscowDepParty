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
    public class RoutesController : ControllerBase
    {
        private readonly ILogger<RoutesController> _logger;

        public RoutesController(ILogger<RoutesController> logger)
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
                    Place = "748",
                    Name = "Ст. Ховрино - Ст. МЦД Бескудниково",
                    Type = Party.ReferenceEquals,
                    Area = new Party()
                    {
                        Id = 1,
                        Name = "ГУП \"Мосгортранс\"",
                       Area = "Europe/Moscow",
                       Place = "http://mosgortrans.ru"
                    }
                } 
            };
        }
    }
}
