using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace WebAPIBasics.Controllers
{
    [ApiController]
    [Route("api/[Controller]s/[Action]")]
    public class SerializationDeserializationController : Controller
    {
        public class Customer
        {
            public Customer(int Balance, int PIN)
            {
                _Balance = Balance;
                _PIN = PIN;
            }
            public int Id { get; set; }
            public string Name { get; set; }
            [JsonIgnore]
            public string Address { get; set; }

            [JsonRequired]
            private decimal _Balance { get; set; }
            private int _PIN { get; set; }
        }

        [HttpGet]
        public ActionResult<Customer> Simple()
        {
            return new Customer(10000, 1234) { Id = 1, Name = "Dhruvil Dobariya", Address = "Rajkot" };
        }

        [HttpGet]
        public ActionResult<string> Serializer()
        {
            Customer customer = new Customer(10000, 1234) { Id = 1, Name = "Dhruvil Dobariya", Address = "Rajkot" };
            var json = JsonConvert.SerializeObject(customer);
            return json;
        }

        [HttpGet]
        public ActionResult<Customer> Deserializer()
        {
            string str = "{\"Id\":1,\"Name\":\"Dhruvil Dobariya\",\"_Balance\":10000.0}";
            return JsonConvert.DeserializeObject<Customer>(str);
        }
    }
}
