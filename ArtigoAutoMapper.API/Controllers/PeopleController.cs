using ArtigoAutoMapper.API.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ArtigoAutoMapper.API.Controllers
{
    [ApiController]
    [Route("api/{controller}")]
    public class PeopleController : ControllerBase
    {
        private readonly IMapper _mapper;
        public PeopleController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpPost]
        public ActionResult Post(PersonInputModel personInputModel)
        {
            var person = _mapper.Map<Person>(personInputModel);

            return Ok(person);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            // Instanciei para utilizar no exemplo, mas note como não fica agradável para a leitura utilizar um construtor com tantos parâmetros.
            var person = new Person(id, "luis", "felipe", DateTime.Now.AddYears(-27), MaritalStatusEnum.Married, "1234-5678", "rua abcd");

            var personViewModel = _mapper.Map<PersonViewModel>(person);

            return Ok(personViewModel);
        }
    }
}
