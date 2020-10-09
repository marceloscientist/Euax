using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Euax.Models
{
    public class Project
    {
        //public Project(string name, DateTime startDate, DateTime endDate)
        //{
        //    Name = name;
        //    StartDate = startDate;
        //    EndDate = endDate;
        //}

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set;  }

    }
}
