using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
    public class floorColorController : ControllerBase
    {

        private readonly IFloorColor _color;

        public floorColorController(IFloorColor color)
        {
            _color = color;
        }

        // GET: api/<floorWallController>
        [HttpGet]
        public async Task<IEnumerable<floorColor>> Get()
        {
            return await _color.GetFloorColorList();
        }

        // GET api/<floorWallController>/5
        [HttpGet("{id}")]
        public async Task<floorColor> Get(int id)
        {
            return await _color.GetFloorColorById(id);
        }

        // POST api/<floorWallController>
        [HttpPost]
        public async void Post([FromBody] floorColor value)
        {

            await _color.CreateAsync(value);

        }

        // PUT api/<floorWallController>/5
        [HttpPut("{id}")]
        public async void Put([FromBody] floorColor value)
        {
            await _color.UpdateAsync(value);
        }

        // DELETE api/<floorWallController>/5
        [HttpDelete("{id}")]
        public async void Delete(int id)
        {
            var getRecord = await _color.GetFloorColorById(id);
            await _color.DeleteAsysn(getRecord);
        }
    }
}
