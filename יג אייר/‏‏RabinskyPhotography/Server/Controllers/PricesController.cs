﻿

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PricesController : ControllerBase
    {

        IBLPrice blManagerPrices;
        public PricesController(BLManager blManager)
        {
            this.blManagerPrices = blManager.Price;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            if (blManagerPrices.GetAll() != null)
            {
                return Ok(blManagerPrices.GetAll());

            }
            return BadRequest();
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (blManagerPrices.Get(id) != null)
            {
                return Ok(blManagerPrices.Get(id));
            }
            return BadRequest();
        }
          

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }


        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
