using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Role
    {

        public decimal Roleid { get; set; }
        public string Rolename { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }

        
    }
}
