using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Models
{
    public class Report3Object
    {
        public string Time { get; }

        public string Day { get; }

        public int NumberOfViewers { get; }

        public Report3Object(string time, string day, int num)
        {
            Time = time;
            Day = day;
            NumberOfViewers = num;
        }
    }
}
