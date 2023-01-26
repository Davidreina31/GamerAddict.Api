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
    public class VideoGameController : ControllerBase
    {
        private readonly IVideoGameManager _manager;
        private readonly IMapper _mapper;

        public VideoGameController(IVideoGameManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }


        // GET: api/<CityController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VideoGameDTO>>> Get()
        {
            var result = await _manager.GetAll();
            return Ok(result.Select(x => _mapper.Map<VideoGameDTO>(x)));
        }

        // GET api/<CityController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VideoGameDTO>> GetOne(int id)
        {
            var result = await _manager.GetById(id);
            var mapped = _mapper.Map<VideoGameDTO>(result);
            return Ok(mapped);
        }

        // POST api/<CityController>
        [HttpPost]
        public async Task<ActionResult<VideoGameDTO>> Post([FromBody] VideoGameDTO videoGame)
        {
            var result = await _manager.Add(_mapper.Map<VideoGame>(videoGame));
            var mapped = _mapper.Map<VideoGameDTO>(result);
            return Ok(mapped);
        }

        // PUT api/<CityController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<VideoGameDTO>> Put([FromBody] VideoGameDTO videoGame)
        {
            var result = await _manager.Update(_mapper.Map<VideoGame>(videoGame));
            var mapped = _mapper.Map<VideoGameDTO>(result);
            return Ok(mapped);
        }

        // DELETE api/<CityController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<VideoGameDTO>> Delete(int id)
        {
            var result = await _manager.Delete(id);
            var mapped = _mapper.Map<VideoGameDTO>(result);
            return Ok(mapped);
        }
    }
}
