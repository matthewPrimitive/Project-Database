using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Models
{
    public class ShowTime
    {
        public int ShowTimeId { get; }

        public int MovieId { get; }

        public string Time { get; }

        public string Date { get; }

        public decimal Price { get; }

        public ShowTime (int showtimeid, int movieid, string time, string date, decimal price)
        {
            ShowTimeId = showtimeid;
            MovieId = movieid;
            Time = time;
            Date = date;
            Price = price;
        }

        public override string ToString()
        {
            return Time.ToString() + "              " + Date.ToString() + "             $" + Price.ToString();
        }
    }
}
