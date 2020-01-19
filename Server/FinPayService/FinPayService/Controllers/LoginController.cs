using FinPay.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using static FinPayService.Helper;

namespace FinPayService.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
<<<<<<< HEAD
        private global::FinPay.DataAccess.FinPay _context;
        private readonly AppSettings _appSettings;
        public LoginController(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody]User user)
        {
            var userIdentity =  Helper.Authenticate(user.Username, user.Password);

            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            // return basic user info (without password) and token to store client side
            return Ok(new
            {
                Id = user.Id,
                Username = user.Username,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Token = tokenString
            });
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public IActionResult Register([FromBody]User user, string password)
        {
            
            try
            {
                byte[] passwordHash, passwordSalt;
                Helper.CreatePasswordHash(password, out passwordHash, out passwordSalt);

                user.PasswordHash = passwordHash;
                user.PasswordSalt = passwordSalt;

                _context.SaveChanges();
                var logindata = _context.Login.FirstOrDefault(l => l.UserID == UserID && l.Password == pwd);
                logindata.UserID = "aa";
                logindata.Password = "aa";
                _context.user.Update(logindata);
                _context.Login.Add(logindata);
                _context.SaveChanges();

                return Ok();

            }
            catch (Exception ex)
            {
                // return error message if there was an exception
                return BadRequest(new { message = ex.Message });
            }
=======
        private global::FinPay.DataAccess.FinPayDbContext  _context;
        public LoginController(global::FinPay.DataAccess.FinPayDbContext  finPay)
        {
            _context = finPay;
        }

        // GET api/values/5
        [HttpPost("{UserID}/{pwd}")]
        public ActionResult<string> Get(string UserID, string pwd)
        {
            var logindata = _context.Login.Select(l => l.UserID == UserID && l.Password == pwd);
            return logindata != null ? "CCCLOCKRLLLL" : (ActionResult<string>)string.Empty;

            //return new Login() { Email = email, Pwd = pwd, PartnersID = 1, PartnersName = "Test user" };
>>>>>>> 87e99cd6c3351e4eea6fd46271d0828bfaf0be68
        }
    }
}