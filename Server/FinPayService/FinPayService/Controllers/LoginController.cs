using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinPay.DataAccess.Models;
using FinPay.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinPayService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private global::FinPay.DataAccess.FinPay _context;
        public LoginController(global::FinPay.DataAccess.FinPay finPay)
        {
            _context = finPay;
        }

        // GET api/values/5
        [HttpPost("{UserID}/{pwd}")]
        public ActionResult<string> Get(string UserID, string pwd)
        {
            var logindata = _context.Login.Select(l=>l.UserID == UserID && l.Password== pwd)
            return logindata != null ? "CCCLOCKRLLLL" : (ActionResult<string>)string.Empty;

            //return new Login() { Email = email, Pwd = pwd, PartnersID = 1, PartnersName = "Test user" };
        }
    }
}