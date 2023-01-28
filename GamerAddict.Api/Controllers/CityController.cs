using AutoMapper;
using GamerAddict.BLL.Interfaces.Managers;
using GamerAddict.Domain.Entity;
using GamerAddict.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GamerAddict.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ICityManager _manager;
        private readonly IMapper _mapper;

        public CityController(ICityManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }


        // GET: api/<CityController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CityDTO>>> Get()
        {
            var result = await _manager.GetAll();
            return Ok(result.Select(x => _mapper.Map<CityDTO>(x)));
        }

        // GET api/<CityController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CityDTO>> GetOne(int id)
        {
            var result = await _manager.GetById(id);
            var mapped = _mapper.Map<CityDTO>(result);
            return Ok(mapped);
        }

        // POST api/<CityController>
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<CityDTO>> Post([FromBody] CityDTO city)
        {
            var result = await _manager.Add(_mapper.Map<City>(city));
            var mapped = _mapper.Map<CityDTO>(result);
            return Ok(mapped);
        }

        // PUT api/<CityController>/5
        [HttpPut("{id}")]
        [Authorize]
        public async Task<ActionResult<CityDTO>> Put([FromBody] CityDTO city)
        {
            var result = await _manager.Update(_mapper.Map<City>(city));
            var mapped = _mapper.Map<CityDTO>(result);
            return Ok(mapped);
        }

        // DELETE api/<CityController>/5
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<ActionResult<CityDTO>> Delete(int id)
        {
            var result = await _manager.Delete(id);
            var mapped = _mapper.Map<CityDTO>(result);
            return Ok(mapped);
        }
    }
}
