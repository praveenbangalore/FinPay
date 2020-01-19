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
    public class InvoiceController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Invoice>> Get()
        {
            return new Invoice[] {  
            new Invoice(){ InvoiceID = 1, InvoiceNumber = "Starge 1" },
            new Invoice(){ InvoiceID = 2, InvoiceNumber = "Starge 3" },
            };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Invoice> Get(int id)
        {
            return new Invoice();
        }


        // POST api/values
        [HttpPost]
        public bool Post(Invoice invoice)
        {
            return true;
        }
    }
}