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
    public class PlateformController : ControllerBase
    {
        private readonly IPlateformManager _manager;
        private readonly IMapper _mapper;

        public PlateformController(IPlateformManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }


        // GET: api/<CityController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlateformDTO>>> Get()
        {
            var result = await _manager.GetAll();
            var mapped = _mapper.Map<PlateformDTO>(result);
            return Ok(mapped);
        }

        // GET api/<CityController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PlateformDTO>> GetOne(int id)
        {
            var result = await _manager.GetById(id);
            var mapped = _mapper.Map<PlateformDTO>(result);
            return Ok(mapped);
        }

        // POST api/<CityController>
        [HttpPost]
        public async Task<ActionResult<PlateformDTO>> Post([FromBody] PlateformDTO plateform)
        {
            var result = await _manager.Add(_mapper.Map<Plateform>(plateform));
            var mapped = _mapper.Map<PlateformDTO>(result);
            return Ok(mapped);
        }

        // PUT api/<CityController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<PlateformDTO>> Put([FromBody] PlateformDTO plateform)
        {
            var result = await _manager.Update(_mapper.Map<Plateform>(plateform));
            var mapped = _mapper.Map<PlateformDTO>(result);
            return Ok(mapped);
        }

        // DELETE api/<CityController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PlateformDTO>> Delete(int id)
        {
            var result = await _manager.Delete(id);
            var mapped = _mapper.Map<PlateformDTO>(result);
            return Ok(mapped);
        }
    }
}
