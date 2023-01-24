﻿using AutoMapper;
using GamerAddict.BLL.Interfaces.Managers;
using GamerAddict.Domain.Entity;
using GamerAddict.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GamerAddict.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionManager _manager;
        private readonly IMapper _mapper;

        public QuestionController(IQuestionManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }


        // GET: api/<CityController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<QuestionDTO>>> Get()
        {
            var result = await _manager.GetAll();
            var mapped = _mapper.Map<QuestionDTO>(result);
            return Ok(mapped);
        }

        // GET api/<CityController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<QuestionDTO>> GetOne(int id)
        {
            var result = await _manager.GetById(id);
            var mapped = _mapper.Map<QuestionDTO>(result);
            return Ok(mapped);
        }

        // POST api/<CityController>
        [HttpPost]
        public async Task<ActionResult<QuestionDTO>> Post([FromBody] QuestionDTO question)
        {
            var result = await _manager.Add(_mapper.Map<Question>(question));
            var mapped = _mapper.Map<QuestionDTO>(result);
            return Ok(mapped);
        }

        // PUT api/<CityController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<QuestionDTO>> Put([FromBody] QuestionDTO question)
        {
            var result = await _manager.Update(_mapper.Map<Question>(question));
            var mapped = _mapper.Map<QuestionDTO>(result);
            return Ok(mapped);
        }

        // DELETE api/<CityController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<QuestionDTO>> Delete(int id)
        {
            var result = await _manager.Delete(id);
            var mapped = _mapper.Map<QuestionDTO>(result);
            return Ok(mapped);
        }
    }
}