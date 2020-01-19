using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinPay.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinPayService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {        
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Payment>> Get()
        {
            return new Payment[] {
            new Payment(){ },
            new Payment(){ },
            };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Payment> Get(int id)
        {
            return new Payment();
        }

        // POST api/values
        [HttpPost]
        public bool Post(Payment invoice)
        {
            return true;
        }
    }
}