using Company.API.Extensions;
using Company.Common.DTOs;
using Company.Data.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Company.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnställdController : ControllerBase
    {
        private readonly IDbService _db;
        public AnställdController(IDbService db) => _db = db;
        // GET: api/<AnställdController>
        [HttpGet]
        public async Task<IResult> Get() => await _db.HttpGetAsync<Anställd , AnställdDTO>();

        // GET api/<CoursesController>/5
        [HttpGet("{id}")]
        public async Task<IResult> Get(int id) => await _db.HttpGetSingleAsync<Anställd, AnställdDTO>(id);


        // POST api/<CoursesController>
        [HttpPost]
        public async Task<IResult> Post([FromBody] AnställdDTO dto) => await _db.HttpPost<Anställd, AnställdDTO>(dto);


        // PUT api/<CoursesController>/5
        [HttpPut("{id}")]
        public async Task<IResult> Put(int id, [FromBody] AnställdDTO dto) => await _db.HttpPut<Anställd, AnställdDTO>(id, dto);


        // DELETE api/<CoursesController>/5
        [HttpDelete("{id}")]
        public async Task<IResult> Delete(int id) => await _db.HttpDeleteAsync<Anställd>(id);

    }
}
