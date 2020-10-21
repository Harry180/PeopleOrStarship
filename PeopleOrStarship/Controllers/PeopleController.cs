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
    public class PeopleController : ControllerBase
    {
        private readonly IRandomizeService _randomizeService;

        public PeopleController(IRandomizeService randomizeService)
        {
            _randomizeService = randomizeService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _randomizeService.Get();

            return Ok(result);
        }
    }
}