using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Testmonial
    {
        public decimal Testmonialid { get; set; }
        public decimal? Acoountid { get; set; }
        public string Testmonialcomment { get; set; }
        public decimal? Rate { get; set; }
        public string Testmonialstatus { get; set; }

        public virtual Account Acoount { get; set; }
    }
}
