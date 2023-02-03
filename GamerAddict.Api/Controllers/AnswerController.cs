using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    public class AnswerController : Controller
    {
        private readonly IAnswerManager _manager;
        private readonly IMapper _mapper;

        public AnswerController(IAnswerManager answerManager, IMapper mapper)
        {
            _manager = answerManager;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AnswerDTO>>> Get()
        {
            var result = await _manager.GetAll();
            return Ok(result.Select(x => _mapper.Map<AnswerDTO>(x)));
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AnswerDTO>> GetOne(int id)
        {
            var result = await _manager.GetById(id);
            var mapped = _mapper.Map<AnswerDTO>(result);
            return Ok(mapped);
        }

        // POST api/values
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<AnswerDTO>> Post([FromBody]AnswerDTO answer)
        {
            answer.AnswerDate = DateTime.Today;
            var result = await _manager.Add(_mapper.Map<Answer>(answer));
            var mapped = _mapper.Map<AnswerDTO>(result);
            return Ok(mapped);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        [Authorize]
        public async Task<ActionResult<AnswerDTO>> Put([FromBody]AnswerDTO answer)
        {
            var result = await _manager.Update(_mapper.Map<Answer>(answer));
            var mapped = _mapper.Map<AnswerDTO>(result);
            return Ok(mapped);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<ActionResult<AnswerDTO>> Delete(int id)
        {
            var result = await _manager.Delete(id);
            var mapped = _mapper.Map<AnswerDTO>(result);
            return Ok(mapped);
        }
    }
}

