using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Euax.Models
{
    public class Activity
    {
        //public Activity(Project project, string name, DateTime startDate, DateTime endDate, bool isFinished = false)
        //{
        //    Project = project;
        //    Name = name;
        //    StartDate = startDate;
        //    EndDate = endDate;
        //    IsFinished = isFinished;
        //}

        public int Id { get; set;  }
        public Project Project { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public bool IsFinished { get; set; }
    }
}
