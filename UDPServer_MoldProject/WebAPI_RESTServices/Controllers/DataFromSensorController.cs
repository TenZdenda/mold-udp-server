using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_RESTServices.DataFromSensorManager;
using WebAPI_RESTServices.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI_RESTServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataFromSensorController : ControllerBase
    {

        private IDataManager _manager;
                
        public DataFromSensorController(DataFromSensorContext context)
        {           
            _manager = new DataManagerDB(context);
        }
       
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [HttpGet]
        public ActionResult<IEnumerable<DataFromSensor>> Get()
        {
            IEnumerable<DataFromSensor> result = _manager.GetAll();
            if (result.Count() == 0) return NoContent();
            return Ok(result);
        }

        // GET api/<DataFromSensorController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DataFromSensorController>
        [ProducesResponseType(StatusCodes.Status201Created)]
        [HttpPost]
        public void Post([FromBody] DataFromSensor newDataFromSensor)
        {
            _manager.Add(newDataFromSensor);
            //return Created($"/api/Items/{result.Id}", result);
        }

        // PUT api/<DataFromSensorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DataFromSensorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
