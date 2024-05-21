

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

        [HttpGet]
        public IActionResult GetAll()
        {
            if (blManagerAllCustomers.GetAll() != null)
            {
                return Ok(blManagerAllCustomers.GetAll());

            }
            return BadRequest();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (blManagerAllCustomers.Get(id) != null)
            {
                return Ok(blManagerAllCustomers.Get(id));
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
