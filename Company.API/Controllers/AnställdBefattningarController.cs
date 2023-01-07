using Company.API.Extensions;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Company.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AnställdBefattningarController : ControllerBase
{
    private readonly IDbService _db;
    public AnställdBefattningarController(IDbService db) => _db = db;
    // GET: api/<AnställdBefattningarController>
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

    // GET api/<AnställdBefattningarController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/<AnställdBefattningarController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<AnställdBefattningarController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<AnställdBefattningarController>/5
    [HttpDelete("{id}")]
    public async Task<IResult> Delete(int id) => await _db.HttpDelete<Företag>(id);
}
