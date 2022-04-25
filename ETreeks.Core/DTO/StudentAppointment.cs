using System;
using System.Collections.Generic;
using System.Text;

namespace ETreeks.Core.DTO
{
  public  class StudentAppointment
    {
        public string Coursename { get; set; }
        public decimal Courseid { get; set; }
        public DateTime? Startdate { get; set; }
        public string? Houre { get; set; }
        public string appointmentstatus { get; set; }
        public decimal Appointmentid { get; set; }
        public string Email { get; set; }

    }
}
