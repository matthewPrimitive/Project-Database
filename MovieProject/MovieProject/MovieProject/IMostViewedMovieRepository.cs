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
    public interface IMostViewedMovieRepository
    {
        IReadOnlyList<Report2Object> MostViewed(string start, string end);
    }
}
