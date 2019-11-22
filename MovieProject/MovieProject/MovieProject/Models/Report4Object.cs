using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Models
{
    public class Report4Object
    {
        public string Name { get; }

        public decimal OverallRating { get; }

        public Report4Object (string name, decimal rating)
        {
            Name = name;
            OverallRating = rating;
        }
    }
}
