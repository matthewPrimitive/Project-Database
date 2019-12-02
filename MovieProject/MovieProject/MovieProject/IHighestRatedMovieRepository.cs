using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using MovieProject.Models;
using MovieProject.DataDelegates;


namespace MovieProject
{
    public interface IHighestRatedMovieRepository
    {
        IReadOnlyList<Report1Object> RatingOverTime(string start, string end);
    }
}
