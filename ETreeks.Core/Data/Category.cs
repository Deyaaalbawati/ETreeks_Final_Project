using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Category
    {

        public decimal Categoryid { get; set; }
        public string Categoryname { get; set; }
        public string Categorydescription { get; set; }
        public string Categoryimage { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
