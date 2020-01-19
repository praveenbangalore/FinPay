using System;
using System.Collections.Generic;
using System.Text;

namespace FinPay.Models
{
    public class Login
    {
        public int LoginId { get; set; }
        public int PartnerId { get; set; }
        public string UserID { get; set; }
        public string Name { get; set; }
        public string EmailID { get; set; }
        public string Password { get; set; }
        public string OTP { get; set; }
    }
}
