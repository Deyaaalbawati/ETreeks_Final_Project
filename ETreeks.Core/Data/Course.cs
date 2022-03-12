using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Course
    {

        public decimal Courseid { get; set; }
        public decimal? Acoountid { get; set; }
        public decimal? Categoryid { get; set; }
        public string Coursename { get; set; }
        public string Coursedescription { get; set; }
        public string Courseimage { get; set; }
        public string Courserate { get; set; }
        public string Coursebook { get; set; }
        public string Coursehomework { get; set; }
        public string Coursevideo { get; set; }

        public virtual Account Acoount { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
