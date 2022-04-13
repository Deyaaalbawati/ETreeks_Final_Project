using System;
using System.Collections.Generic;
using System.Text;

namespace ETreeks.Core.DTO
{
    public class AppointmentTeacher
    {
        public decimal Appointmentid { get; set; }
        public decimal? Acoountid { get; set; }
        public decimal? Courseid { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public string Appointmentstatus { get; set; }
        public string? Houre { get; set; }

        public decimal? Categoryid { get; set; }
        public string Coursename { get; set; }
        public string Coursedescription { get; set; }
        public string Courseimage { get; set; }
        public string Courserate { get; set; }
        public string Coursebook { get; set; }
        public string Coursehomework { get; set; }
        public string Coursevideo { get; set; }
    }
}
