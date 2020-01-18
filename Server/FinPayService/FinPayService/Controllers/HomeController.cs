using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinPay.Engine;
using Microsoft.AspNetCore.Mvc;
using FinPay = FinPay.DataAccess.FinPay;

namespace FinPayService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private global::FinPay.DataAccess.FinPay _context;

        public HomeController(global::FinPay.DataAccess.FinPay finPay)
        {
            _context= finPay;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<int> Get()
        {
            return 1;
            // return _context.AccountInfo.Select(a=>a.AccountNo).FirstOrDefault();
        }
    }
}
