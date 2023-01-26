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
    public class CommentController : ControllerBase
    {
        private readonly ICommentManager _manager;
        private readonly IMapper _mapper;

        public CommentController(ICommentManager commentManager, IMapper mapper)
        {
            _manager = commentManager;
            _mapper = mapper;
        }

        // GET: api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CommentDTO>>> Get()
        {
            var result = await _manager.GetAll();
            return Ok(result.Select(x => _mapper.Map<CommentDTO>(x)));

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CommentDTO>> GetOne(int id)
        {
            var result = await _manager.GetById(id);
            var mapped = _mapper.Map<CommentDTO>(result);
            return Ok(mapped);
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult<CommentDTO>> Post([FromBody] CommentDTO commentDTO)
        {
            var result = await _manager.Add(_mapper.Map<Comment>(commentDTO));
            var mapped = _mapper.Map<CommentDTO>(result);
            return Ok(mapped);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<ActionResult<CommentDTO>> Put([FromBody] CommentDTO commentDTO)
        {
            var result = await _manager.Update(_mapper.Map<Comment>(commentDTO));
            var mapped = _mapper.Map<CommentDTO>(result);
            return Ok(mapped);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CommentDTO>> Delete(int id)
        {
            var result = await _manager.Delete(id);
            var mapped = _mapper.Map<CommentDTO>(result);
            return Ok(mapped);
        }
    }
}
