using System;
using System.Collections.Generic;
using System.Text;

namespace ETreeks.Core.DTO
{
   public class TeacherDashboardAppintment
    {

        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public string firstnameStudent { get; set; }

        public string lastnameStudent { get; set; }

        public string appointmentstatus { get; set; }

        public DateTime? Startdate { get; set; }

        public string? Houre { get; set; }

        public decimal? Categoryid { get; set; }
        public string Coursename { get; set; }
    }
}
