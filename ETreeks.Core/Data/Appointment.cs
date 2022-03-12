using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Appointment
    {
        public decimal Appointmentid { get; set; }
        public decimal? Acoountid { get; set; }
        public decimal? Courseid { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public string Appointmentstatus { get; set; }

        public virtual Account Acoount { get; set; }
        public virtual Course Course { get; set; }
    }
}
