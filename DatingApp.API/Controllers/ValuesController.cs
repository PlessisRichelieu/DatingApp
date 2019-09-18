using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DatingApp.API.Models;
using DatingApp.API.Data;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _DataContext;
        public ValuesController (DataContext data)
        {
            this._DataContext = data;
        }
        // GET api/values
        [HttpGet]
        async public Task <IActionResult> Get()
        {
            var values = await _DataContext.Value.ToListAsync();
            return Ok(values);
        
        }
        // GET api/values/5
        [HttpGet("{id}")]   
        async public Task <IActionResult> GetValue(int id)
        {
           var value = await _DataContext.Value.FirstOrDefaultAsync(x=> x.Id == id);

           return Ok(value);
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
