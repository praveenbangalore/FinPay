using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinPay.DataAccess.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinPayService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private global::FinPay.DataAccess.FinPay _context;
        public InvoiceController(global::FinPay.DataAccess.FinPay finPay)
        {
            _context = finPay;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<int> Get()
        {
            return _context.Invoice.Select(i=>i.InvoiceId).FirstOrDefault();

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