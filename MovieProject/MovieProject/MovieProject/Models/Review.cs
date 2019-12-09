using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieProject;
using DataAccess;
using MovieProject.Models;

namespace MovieProject.Models
{
    public class Review
    {
        const string connectionString = @"Data Source=mssql.cs.ksu.edu;Initial Catalog=jamesmmatt;User Id=jamesmmatt;Password=Choppers7;";

        private IActorRepository actorRepo;
        private IMovieRepository movieRepo;
        private IReviewRepository reviewRepo;
        private IShowTimeRepository showtimeRepo;
        private ITicketRepository ticketRepo;
        private IViewerRepository viewerRepo;



        public int ReviewId { get; }

        public int MovieId { get; }

        public int ViewerId { get; }

        public string ReviewMessage { get; }

        public decimal Rating { get; }

        public Review (int reviewid, int movieid, int viewerid, string reviewmessage, decimal rating)
        {
            ReviewId = reviewid;
            MovieId = movieid;
            ViewerId = viewerid;
            ReviewMessage = reviewmessage;
            Rating = rating;
        }
        

        public string ToString()
        {
            actorRepo = new SqlActorRepository(connectionString);
            movieRepo = new SqlMovieRepository(connectionString);
            reviewRepo = new SqlReviewRepository(connectionString);
            showtimeRepo = new SqlShowTimeRepository(connectionString);
            ticketRepo = new SqlTicketRepository(connectionString);
            viewerRepo = new SqlViewerRepository(connectionString);

            Viewer v = viewerRepo.FetchViewer(ViewerId);

            string name = v.Name;

            return "\nUser: " + name + "    \nReview: " + ReviewMessage + "     \nRating: " + Rating;
        }
    }
}
