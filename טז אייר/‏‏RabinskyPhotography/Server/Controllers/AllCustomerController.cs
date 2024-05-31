

using Bl.BlModels;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AllCustomerController : ControllerBase
    {
        IBLAllCustomer blManagerAllCustomers;
        public AllCustomerController(BLManager blManager)
        {
            this.blManagerAllCustomers = blManager.AllCustomer;
        }
        //לבדוק שאין דרך יותר יפה 

        [HttpGet]
        public IActionResult GetAll([FromQuery] string? phon=null)
        {
            if(phon != null)
            {
                if (blManagerAllCustomers.GetByPhon(phon) != null)
                {
                    return Ok(blManagerAllCustomers.GetByPhon(phon));

                }
            }

            else if (blManagerAllCustomers.GetAll() != null)
            {
                return Ok(blManagerAllCustomers.GetAll());

            }
            return BadRequest();
        }
        //לבדוק מה קורה אם אני רוצה גם getById
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (blManagerAllCustomers.Get(id) != null)
            {
                return Ok(blManagerAllCustomers.Get(id));
            }
            return BadRequest();
        }

        //[HttpGet("{phon}")]
        //public IActionResult GetByPhon(string phon)
        //{
        //    if (blManagerAllCustomers.GetByPhon(phon) != null)
        //    {
        //        return Ok(blManagerAllCustomers.GetByPhon(phon));
        //    }
        //    return BadRequest();
        //}

        [HttpPost]
        public void Post([FromBody] BLAllCustomer value)
        {
            blManagerAllCustomers.Post(value);
        }
        //לא עובד לבדוק למה וגם פוסט-אותו שגיאה
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] BLAllCustomer value)
        {
            if (blManagerAllCustomers.Get(id) != null)
            {
                return Ok(blManagerAllCustomers.Put(value));
            }
            return BadRequest();
            
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
