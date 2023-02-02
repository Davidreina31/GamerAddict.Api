using AutoMapper;
using GamerAddict.BLL.Interfaces.Managers;
using GamerAddict.Domain.Entity;
using GamerAddict.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GamerAddict.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlateformVideoGameController : ControllerBase
    {
        private readonly IPlateform_VideoGameManager _manager;
        private readonly IMapper _mapper;

        public PlateformVideoGameController(IPlateform_VideoGameManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }


        // GET: api/<CityController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Plateform_VideoGameDTO>>> Get()
        {
            var result = await _manager.GetAll();
            return Ok(result.Select(x => _mapper.Map<Plateform_VideoGameDTO>(x)));
        }

        // GET api/<CityController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Plateform_VideoGameDTO>> GetAllForVideoGameId(int id)
        {
            var result = await _manager.GetAllForVideoGameId(id);
            return Ok(result.Select(x => _mapper.Map<Plateform_VideoGameDTO>(x)));
        }

        // POST api/<CityController>
        [HttpPost]
        [Authorize]

        public async Task<ActionResult<Plateform_VideoGameDTO>> Post([FromBody] Plateform_VideoGameDTO plateform_VideoGame)
        {
            var result = await _manager.Add(_mapper.Map<Plateform_VideoGame>(plateform_VideoGame));
            var mapped = _mapper.Map<Plateform_VideoGameDTO>(result);
            return Ok(mapped);
        }

        // PUT api/<CityController>/5
        [HttpPut("{id}")]
        [Authorize]

        public async Task<ActionResult<Plateform_VideoGameDTO>> Put([FromBody] Plateform_VideoGameDTO plateform_VideoGame)
        {
            var result = await _manager.Update(_mapper.Map<Plateform_VideoGame>(plateform_VideoGame));
            var mapped = _mapper.Map<Plateform_VideoGameDTO>(result);
            return Ok(mapped);
        }

        // DELETE api/<CityController>/5
        [HttpDelete("{id}")]
        [Authorize]

        public async Task<ActionResult<Plateform_VideoGameDTO>> Delete(int id)
        {
            var result = await _manager.Delete(id);
            var mapped = _mapper.Map<Plateform_VideoGameDTO>(result);
            return Ok(mapped);
        }
    }
}
