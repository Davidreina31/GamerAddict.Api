using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GamerAddict.BLL.Interfaces.Managers;
using GamerAddict.Domain.Entity;
using GamerAddict.Dto;
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

        // GET: api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AnswerDTO>>> Get()
        {
            var result = await _manager.GetAll();
            var mapped = _mapper.Map<AnswerDTO>(result);
            return Ok(mapped);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Answer>> GetOne(int id)
        {
            return Ok(await _manager.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult<Answer>> Post([FromBody]Answer answer)
        {
            return Ok(await _manager.Add(answer));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

