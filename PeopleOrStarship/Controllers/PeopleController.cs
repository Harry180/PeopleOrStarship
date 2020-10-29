using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PeopleOrStarship.Data;
using PeopleOrStarship.Data.Entities;
using PeopleOrStarship.Data.Repositories;
using PeopleOrStarship.Service;

namespace PeopleOrStarship.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class PeopleController : ControllerBase
    {
        private readonly IRandomizeService _randomizeService;
        private readonly  IRepository<Person> _peopleRepository;

        public PeopleController(IRandomizeService randomizeService, IRepository<Person> peopleRepository)
        {
            _randomizeService = randomizeService;
            _peopleRepository = peopleRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _randomizeService.Get();

            return Ok(result);
        }

        [HttpGet]
        [Route("api/get/{id}")]
        public IActionResult GetPerson(int id)
        {
            return Ok(_peopleRepository.GetById(id));
        }

        [HttpGet]
        [Route("api/getAll")]
        public IActionResult GetAll()
        {
            var people = _peopleRepository.GetAll();
            return Ok(people);
        }
        
        [HttpPost]
        [Route("api/CreateOrUpdate")]
        public IActionResult CreateOrUpdate([FromBody] Person model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var person = _peopleRepository.CreateOrUpdate(model);

            return Ok(person);
        }

        [HttpDelete]
        [Route("api/Delete/{id}")]
        public IActionResult Delete(int id)
        {
            _peopleRepository.Delete(id);

            return Ok();
        }
    }
}