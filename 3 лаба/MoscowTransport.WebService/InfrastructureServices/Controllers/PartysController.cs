using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Partys.DomainObjects;

namespace Partys.WebService.InfrastructureServices.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PartyController : ControllerBase
    {
        private readonly ILogger<PartyController> _logger;

        public PartyController(ILogger<PartyController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Party> GetAllRoutes()
        {
            return new List<Party>()
            {
                new Party()
                {
                    Id = 1,
                    Name = "Культурно-массовое мероприятие «День космонавтики",
                    Organization = new MskParty()
                    {
                        Id = 1,
                        Name = "Мероприятия, организованные при поддержке Департамента культуры города Москвы\"",
                        TimeZone = "Europe/Moscow",
                        WebSite = "https://data.mos.ru/opendata/7702155262-programma-kulturnyh-meropriyatiy-organizovannyh-pri-podderjke-pravitelstva-moskvy?pageNumber=2&versionNumber=2&releaseNumber=51"
                    }
                }
            };
        }
    }
}

