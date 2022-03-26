using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Account
    {

        public decimal Acoountid { get; set; }
        public decimal? Roleid { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Accountpassword { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }
        public string Gender { get; set; }
        public DateTime? Birthofdate { get; set; }
        public string Profilepicture { get; set; }
        public string Accountstatus { get; set; }
        public string Certificate { get; set; }
        public string Specialization { get; set; }
        public string Wline { get; set; }
        public string Hline { get; set; }


        public virtual Role Role { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Testmonial> Testmonials { get; set; }
    }
}
