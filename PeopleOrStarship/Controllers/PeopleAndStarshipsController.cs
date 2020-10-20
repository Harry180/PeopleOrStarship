using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PeopleOrStarship.Data;
using PeopleOrStarship.Data.Entities;
using PeopleOrStarship.Service;

namespace PeopleOrStarship.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PeopleAndStarshipsController : ControllerBase
    {
        private readonly IRandomizeService _randomizeService;

        public PeopleAndStarshipsController(IRandomizeService randomizeService)
        {
            _randomizeService = randomizeService;
        }

        [HttpGet(Name = "GetPeople")]
        public IActionResult GetPeople()
        {
            var result = new List<People>();
            result.Add(_randomizeService.Get());
            result.Add(_randomizeService.Get());

            return Ok(result);
        }
    }
}