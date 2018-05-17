using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chaunce.EasyRedis;
using Microsoft.AspNetCore.Mvc;

namespace ExampleWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IRedisCache _provider;
        public ValuesController(IRedisCache provider)
        {
            _provider = provider;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            _provider.CustomPrefixKey = "www:";//改边默认key
            _provider.Set("demo", "yyy", TimeSpan.FromMinutes(1));
            var str2 = _provider.Get("demo", () => { return "缓存"; }, TimeSpan.FromMinutes(1));
            _provider.CustomPrefixKey = "EEE:";//继续改边默认key
            var str3 = _provider.Get("demo", () => { return "缓存"; }, TimeSpan.FromMinutes(1));

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
