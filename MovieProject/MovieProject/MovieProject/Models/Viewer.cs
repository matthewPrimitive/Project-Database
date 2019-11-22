using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Models
{
    public class Viewer
    {
        public int ViewerId { get; }
        
        public string Gender { get; }

        public string Name { get; }

        public string Email { get; }

        public string BirthDate { get; }

        public string Username { get; }

        public Viewer (int viewerid, string gender, string name, string email, string birthdate, string username)
        {
            ViewerId = viewerid;
            Gender = gender;
            Name = name;
            Email = email;
            BirthDate = birthdate;
            Username = username;
        }
    }
}
