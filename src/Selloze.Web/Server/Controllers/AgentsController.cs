using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Selloze.Web.Server.Data;
using Selloze.Web.Server.Models;
using Selloze.Web.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Selloze.Web.Server.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class AgentsController : ControllerBase
    {
        private ApplicationDbContext applicationDbContext;


        //class constructor
        public AgentsController(ApplicationDbContext dbContext)
        {
            applicationDbContext = dbContext;
        }

        // GET: api/<AgentsController>
        [HttpGet("{user}")]
        public async Task<IEnumerable<string>> Get(string user)
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<AgentsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AgentsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AgentsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AgentsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
