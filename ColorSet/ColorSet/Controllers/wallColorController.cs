using Microsoft.AspNetCore.Mvc;
using SetColorLibrary.Interface;
using SetColorLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ColorSet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class wallColorController : ControllerBase
    {

        private readonly IWallColor _color;

        public wallColorController(IWallColor color)
        {
            _color = color;
        }

        // GET: api/<wallColorController>
        [HttpGet]
        public async Task<IEnumerable<wallColor>> Get()
        {
            return await _color.GetWallColorList();
        }

        // GET api/<wallColorController>/5
        [HttpGet("{id}")]
        public async Task<wallColor> Get(int id)
        {
            return await _color.GetWallColorById(id);
        }

        // POST api/<wallColorController>
        [HttpPost]
        public async void Post([FromBody] wallColor value)
        {

            await _color.CreateAsync(value);

        }

        // PUT api/<wallColorController>/5
        [HttpPut("{id}")]
        public async void Put([FromBody] wallColor value)
        {
            await _color.UpdateAsync(value);
        }

        // DELETE api/<wallColorController>/5
        [HttpDelete("{id}")]
        public async void Delete(int id)
        {
            var getRecord = await _color.GetWallColorById(id);
            await _color.DeleteAsysn(getRecord);
        }
    }
}
