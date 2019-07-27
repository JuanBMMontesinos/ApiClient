using Business.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ApiClient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private readonly IApplication _app;

        public ValuesController(IApplication app)
        {
            _app = app;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Client value)
        {
            _app.Add(value);
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
