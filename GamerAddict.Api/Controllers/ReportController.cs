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
    public class ReportController : ControllerBase
    {
        private readonly IReportManager _manager;
        private readonly IMapper _mapper;

        public ReportController(IReportManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }


        // GET: api/<CityController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReportDTO>>> Get()
        {
            var result = await _manager.GetAll();
            var mapped = _mapper.Map<ReportDTO>(result);
            return Ok(mapped);
        }

        // GET api/<CityController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ReportDTO>> GetOne(int id)
        {
            var result = await _manager.GetById(id);
            var mapped = _mapper.Map<ReportDTO>(result);
            return Ok(mapped);
        }

        // POST api/<CityController>
        [HttpPost]
        public async Task<ActionResult<ReportDTO>> Post([FromBody] ReportDTO report)
        {
            var result = await _manager.Add(_mapper.Map<Report>(report));
            var mapped = _mapper.Map<ReportDTO>(result);
            return Ok(mapped);
        }

        // PUT api/<CityController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<ReportDTO>> Put([FromBody] ReportDTO report)
        {
            var result = await _manager.Update(_mapper.Map<Report>(report));
            var mapped = _mapper.Map<ReportDTO>(result);
            return Ok(mapped);
        }

        // DELETE api/<CityController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ReportDTO>> Delete(int id)
        {
            var result = await _manager.Delete(id);
            var mapped = _mapper.Map<ReportDTO>(result);
            return Ok(mapped);
        }
    }
}
