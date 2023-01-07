using Company.API.Extensions;
using Company.Common.DTOs;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Company.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AvdelningController : ControllerBase
{
    private readonly IDbService _db;
    public AvdelningController(IDbService db) => _db = db;
    // GET: api/<AvdelningController>
    [HttpGet]
    public async Task<IResult> Get() => await _db.HttpGetAsync<Avdelning , AvdelningDTO>();

    // GET api/<CoursesController>/5
    [HttpGet("{id}")]
    public async Task<IResult> Get(int id) => await _db.HttpGetSingleAsync<Avdelning, AvdelningDTO>(id);


    // POST api/<CoursesController>
    [HttpPost]
    public async Task<IResult> Post([FromBody] AvdelningDTO dto) => await _db.HttpPost<Avdelning, AvdelningDTO>(dto);


    // PUT api/<CoursesController>/5
    [HttpPut("{id}")]
    public async Task<IResult> Put(int id, [FromBody] AvdelningDTO dto) => await _db.HttpPut<Avdelning, AvdelningDTO>(id, dto);


    // DELETE api/<CoursesController>/5
    [HttpDelete("{id}")]
    public async Task<IResult> Delete(int id) => await _db.HttpDeleteAsync<Avdelning>(id);
}