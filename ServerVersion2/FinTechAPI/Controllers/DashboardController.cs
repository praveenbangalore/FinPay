using AutoMapper;
using FinTechAPI.Entities;
using FinTechAPI.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace FinTechAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class DashboardController : ControllerBase
    {
        private IDashboardService _dashboardService;

        public DashboardController(
            IDashboardService dashboardService)
        {
            _dashboardService = dashboardService;
        }


        [HttpGet("stats")]
        public IActionResult Stats()
        {
            Dashboard dashboard = new Dashboard();
            
            return Ok(new Dashboard { PaymentFailed = 13, TotalInvoices = 66, TotalPayment = 12, TotalResponse= 30 });
            
        }
    }
}
