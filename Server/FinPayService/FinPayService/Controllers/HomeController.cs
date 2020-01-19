using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FinPay = FinPay.DataAccess.FinPayDbContext ;

namespace FinPayService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private global::FinPay.DataAccess.FinPayDbContext  _context;

        public HomeController(global::FinPay.DataAccess.FinPayDbContext  finPay)
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
