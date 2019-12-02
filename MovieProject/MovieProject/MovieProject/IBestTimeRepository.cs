using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess;
using MovieProject.Models;

namespace MovieProject
{
    public interface IBestTimeRepository
    {
        IReadOnlyList<Report3Object> BestTime();
    }
}
