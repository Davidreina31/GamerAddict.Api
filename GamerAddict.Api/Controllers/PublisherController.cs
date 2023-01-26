using AutoMapper;
using GamerAddict.BLL.Interfaces.Managers;
using GamerAddict.Domain.Entity;
using GamerAddict.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GamerAddict.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublisherController : ControllerBase
    {
        private readonly IPublisherManager _manager;
        private readonly IMapper _mapper;

        public PublisherController(IPublisherManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }


        // GET: api/<CityController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PublisherDTO>>> Get()
        {
            var result = await _manager.GetAll();
            return Ok(result.Select(x => _mapper.Map<PublisherDTO>(x)));
        }

        // GET api/<CityController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PublisherDTO>> GetOne(int id)
        {
            var result = await _manager.GetById(id);
            var mapped = _mapper.Map<PublisherDTO>(result);
            return Ok(mapped);
        }

        // POST api/<CityController>
        [HttpPost]
        public async Task<ActionResult<PublisherDTO>> Post([FromBody] PublisherDTO publisher)
        {
            var result = await _manager.Add(_mapper.Map<Publisher>(publisher));
            var mapped = _mapper.Map<PublisherDTO>(result);
            return Ok(mapped);
        }

        // PUT api/<CityController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<PublisherDTO>> Put([FromBody] PublisherDTO publisher)
        {
            var result = await _manager.Update(_mapper.Map<Publisher>(publisher));
            var mapped = _mapper.Map<PublisherDTO>(result);
            return Ok(mapped);
        }

        // DELETE api/<CityController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PublisherDTO>> Delete(int id)
        {
            var result = await _manager.Delete(id);
            var mapped = _mapper.Map<PublisherDTO>(result);
            return Ok(mapped);
        }
    }
}
