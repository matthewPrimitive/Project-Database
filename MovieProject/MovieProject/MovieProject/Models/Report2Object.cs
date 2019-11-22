using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Models
{
    public class Report2Object
    {
        public string Name { get; }

        public int NumberOfViewers { get; }

        public Report2Object(string name, int num)
        {
            Name = name;
            NumberOfViewers = num;
        }
    }
}
