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
    public class LoginController : ControllerBase
    {
        // GET api/values/5
        [HttpGet("{email}")]
        public ActionResult<Login> Get(int email)
        {
            return new Login();
        }
    }
}