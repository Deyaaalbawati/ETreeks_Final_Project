using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Message
    {
        public decimal Messageid { get; set; }
        public decimal? Acoountid { get; set; }
        public string Subject { get; set; }
        public string Messagebody { get; set; }
        public string Senderemail { get; set; }

        public virtual Account Acoount { get; set; }
    }
}
