using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using FinTechAPI.Entities;
using FinTechAPI.Helpers;
using FinTechAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace FinTechAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class DashboardController : ControllerBase
    {
        private IUserService _userService;
        private IMapper _mapper;
        private readonly AppSettings _appSettings;

        public DashboardController(
            IUserService userService,
            IMapper mapper,
            IOptions<AppSettings> appSettings)
        {
            _userService = userService;
            _mapper = mapper;
            _appSettings = appSettings.Value;
        }

        

        public class statistics
        {
            public int totalInvoices { get; set; }
            public int totalPayment { get; set; }
            public int paymentFailed { get; set; }
            public int totalResponse { get; set; }
        }

        [AllowAnonymous]
        [HttpGet("stats")]
        public IActionResult Stats()
        {
            statistics s = new statistics();
            
            return Ok(s);
            
        }
    }
}
