using AutoMapper;
using FinTechAPI.DTOS;
using FinTechAPI.Entities;
using FinTechAPI.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace FinTechAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class InvoiceController : ControllerBase
    {
        private IInvoiceService _invoiceService;

        public InvoiceController(
            IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }

        
        [HttpPost("create")]
        public IActionResult Create([FromBody]Invoice inv)
        {
            var invoice = _invoiceService.Post(inv);
            return Ok(invoice);
        }

        [HttpGet]
        public IActionResult Get()
        {
            var invoice = _invoiceService.Get();
            return Ok(invoice);
        }
    }
}
