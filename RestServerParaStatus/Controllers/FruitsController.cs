using JsonFruit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestServerParaStatus.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestServerParaStatus
{
    [Route("api/[controller]")]
    [ApiController]
    public class FruitsController : ControllerBase
    {
        public FruitManager _manager = new FruitManager();

        // GET: api/<ValuesController>
        [HttpGet("{substring}")]
        public IEnumerable<Fruit> Get(string substring)
        {
            return _manager.GetList(substring);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [HttpGet("Contains/{substring}")]
        public ActionResult<IEnumerable<Fruit>> GetWithContains(string substring)
        {
            List<Fruit> result = _manager.GetList(substring);
            if (result.Count > 0)
            {
                return Ok(result);
            } else
            {
                return NoContent();
            }
        }

        //// GET api/<ValuesController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
