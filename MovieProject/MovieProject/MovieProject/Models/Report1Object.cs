using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Models
{
    public class Report1Object
    {
        public string Name { get; }

        public decimal Rating { get; }

        public Report1Object (string name, decimal rating)
        {
            Name = name;
            Rating = rating;
        }
    }
}
