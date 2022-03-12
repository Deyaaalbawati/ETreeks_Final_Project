using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Account
    {

        public decimal Acoountid { get; set; }
        public decimal? Roleid { get; set; }
        public decimal? Locationid { get; set; }
        public decimal? Managepageid { get; set; }
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

        public virtual Location Location { get; set; }
        public virtual Managepage Managepage { get; set; }
        public virtual Role Role { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
        public virtual ICollection<Testmonial> Testmonials { get; set; }
    }
}
