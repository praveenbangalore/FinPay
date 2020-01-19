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
    public class TransactionsController : ControllerBase
    {
        private ITransactionService _transactionService;

        public TransactionsController(
            ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        
        [HttpGet("get")]
        public IEnumerable<Transaction> get()
        {
            List<Transaction> listTrans = new List<Transaction>();
            listTrans.Add(new Transaction() { Amount = "100", FromAccount = "adsf", ToAccount = "to", TransactionId = "asdfadsf" });
            listTrans.Add(new Transaction() { Amount = "100", FromAccount = "adsf", ToAccount = "to", TransactionId = "asdfadsf" });
            listTrans.Add(new Transaction() { Amount = "100", FromAccount = "adsf", ToAccount = "to", TransactionId = "asdfadsf" });
            return listTrans;
        }

    }
}
