using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinPay.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinPayService.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private global::FinPay.DataAccess.FinPayDbContext  _context;
        public InvoiceController(global::FinPay.DataAccess.FinPayDbContext  finPay)
        {
            _context = finPay;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<Invoice> Get()
        {
            return _context.Invoice.FirstOrDefault();

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