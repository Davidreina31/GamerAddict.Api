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
    public class UserVideoGameController : ControllerBase
    {
        private readonly IUser_VideoGameManager _manager;
        private readonly IMapper _mapper;

        public UserVideoGameController(IUser_VideoGameManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        // GET api/<CityController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User_VideoGameDTO>> GetOne(int id)
        {
            var result = await _manager.GetAll(id);
            return Ok(result.Select(x => _mapper.Map<User_VideoGameDTO>(x)));
        }

        // POST api/<CityController>
        [HttpPost]
        [Authorize]

        public async Task<ActionResult<User_VideoGameDTO>> Post([FromBody] User_VideoGameDTO user_VideoGame)
        {
            var result = await _manager.Add(_mapper.Map<User_VideoGame>(user_VideoGame));
            var mapped = _mapper.Map<User_VideoGameDTO>(result);
            return Ok(mapped);
        }

        // DELETE api/<CityController>/5
        [HttpDelete("{id}")]
        [Authorize]

        public async Task<ActionResult<User_VideoGameDTO>> Delete(int userId, int videoGameId)
        {
            var result = await _manager.DeleteUserVideoGame(userId, videoGameId);
            var mapped = _mapper.Map<User_VideoGameDTO>(result);
            return Ok(mapped);
        }
    }
}
