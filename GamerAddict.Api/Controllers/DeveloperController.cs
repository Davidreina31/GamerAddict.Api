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
    public class DeveloperController : ControllerBase
    {
        private readonly IDeveloperManager _manager;
        private readonly IMapper _mapper;

        public DeveloperController(IDeveloperManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }


        // GET: api/<CityController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DeveloperDTO>>> Get()
        {
            var result = await _manager.GetAll();
            var mapped = _mapper.Map<DeveloperDTO>(result);
            return Ok(mapped);
        }

        // GET api/<CityController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DeveloperDTO>> GetOne(int id)
        {
            var result = await _manager.GetById(id);
            var mapped = _mapper.Map<DeveloperDTO>(result);
            return Ok(mapped);
        }

        // POST api/<CityController>
        [HttpPost]
        public async Task<ActionResult<DeveloperDTO>> Post([FromBody] DeveloperDTO developer)
        {
            var result = await _manager.Add(_mapper.Map<Developer>(developer));
            var mapped = _mapper.Map<DeveloperDTO>(result);
            return Ok(mapped);
        }

        // PUT api/<CityController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<DeveloperDTO>> Put([FromBody] DeveloperDTO developer)
        {
            var result = await _manager.Update(_mapper.Map<Developer>(developer));
            var mapped = _mapper.Map<DeveloperDTO>(result);
            return Ok(mapped);
        }

        // DELETE api/<CityController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DeveloperDTO>> Delete(int id)
        {
            var result = await _manager.Delete(id);
            var mapped = _mapper.Map<DeveloperDTO>(result);
            return Ok(mapped);
        }
    }
}