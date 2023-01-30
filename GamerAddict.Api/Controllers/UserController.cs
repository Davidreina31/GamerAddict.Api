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
    public class UserController : ControllerBase
    {
        private readonly IUserManager _manager;
        private readonly IMapper _mapper;

        public UserController(IUserManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }


        // GET: api/<CityController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDTO>>> Get()
        {
            var result = await _manager.GetAll();
            return Ok(result.Select(x => _mapper.Map<UserDTO>(x)));
        }

        // GET api/<CityController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserDTO>> GetOne(int id)
        {
            var result = await _manager.GetById(id);
            var mapped = _mapper.Map<UserDTO>(result);
            return Ok(mapped);
        }

        [HttpGet("sub/{sub}")]
        public async Task<ActionResult<User>> GetBySub(string sub)
        {
            return Ok(await _manager.GetUserBySub(sub));
        }

        // POST api/<CityController>
        [HttpPost]
        public async Task<ActionResult<UserDTO>> Post([FromBody] UserDTO user)
        {
            var result = await _manager.Add(_mapper.Map<User>(user));
            var mapped = _mapper.Map<UserDTO>(result);
            return Ok(mapped);
        }

        // PUT api/<CityController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<UserDTO>> Put([FromBody] UserDTO user)
        {
            var result = await _manager.Update(_mapper.Map<User>(user));
            var mapped = _mapper.Map<UserDTO>(result);
            return Ok(mapped);
        }

        // DELETE api/<CityController>/5
        [HttpDelete("{id}")]
        [Authorize]

        public async Task<ActionResult<UserDTO>> Delete(int id)
        {
            var result = await _manager.Delete(id);
            var mapped = _mapper.Map<UserDTO>(result);
            return Ok(mapped);
        }
    }
}
