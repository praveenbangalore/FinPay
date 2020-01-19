using FinPay.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinPay.Engine
{
    public class Login
    {
        private global::FinPay.DataAccess.FinPayDbContext _context;
        public Login(global::FinPay.DataAccess.FinPayDbContext finPay)
        {
            _context = finPay;
        }

        public void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        //below methods should have been in BL
        public User Authenticate(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                return null;

            //get user from db and verify the password salt
            
            return new User() { FirstName = "Test User",
            Username = "testuser"};
        }
    }
}
