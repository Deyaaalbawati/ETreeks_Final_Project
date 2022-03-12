using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Location
    {

        public decimal Locationid { get; set; }
        public string Wline { get; set; }
        public string Hline { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
