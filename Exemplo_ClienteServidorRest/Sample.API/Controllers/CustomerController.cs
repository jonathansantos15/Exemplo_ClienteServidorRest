using Sample.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sample.API.Controllers
{
    public class CustomerController : ApiController
    {
        [HttpPost]
        public IHttpActionResult ListAll()
        {
            List<Customer> customers = new List<Customer>();

            customers.Add(new Customer() { Id = Guid.NewGuid(), Name = "Gabriel Jesus", Age = 20 });
            customers.Add(new Customer() { Id = Guid.NewGuid(), Name = "Vinicius Jr", Age = 19 });

            return Ok(customers);
        }
    }
}
