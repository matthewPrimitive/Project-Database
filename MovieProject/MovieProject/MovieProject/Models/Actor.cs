using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Models
{
    public class Actor
    {
        public int ActorId { get; }

        public string Name { get; }

        public Actor (int actorid, string name)
        {
            ActorId = actorid;
            Name = name;
        }
    }
}
