using System;
using System.Collections.Generic;
using System.Text;

namespace FinPay.Models
{
    public class Login
    {
        public string Email { get; set; }
        public string Pwd { get; set; }
        public int PartnersID { get; set; }
        public string PartnersName { get; set; }

    }
}
