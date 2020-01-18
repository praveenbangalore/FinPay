using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FinPay.Engine
{
    class Partner
    {
        [Required]
        public int PartnerId { get; set; }

        [StringLength(255)]
        public string PartnerName { get; set; }

    }
}
