using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PeopleOrStarship.Data;
using PeopleOrStarship.Data.Entities;
using PeopleOrStarship.Service;

namespace PeopleOrStarship.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StarshipsController : ControllerBase
    {
        private readonly IRandomizeService _randomizeService;

        public StarshipsController(IRandomizeService randomizeService)
        {
            _randomizeService = randomizeService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _randomizeService.GetStarship();

            return Ok(result);
        }
    }
}