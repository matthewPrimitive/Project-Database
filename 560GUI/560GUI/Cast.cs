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

namespace _560GUI
{
    public partial class Cast : Form
    {
        const string connectionString = @"Data Source=mssql.cs.ksu.edu;Initial Catalog=jamesmmatt;User Id=jamesmmatt;Password=Choppers7;";

        private IActorRepository actorRepo;
        private IMovieRepository movieRepo;
        private IReviewRepository reviewRepo;
        private IShowTimeRepository showtimeRepo;
        private ITicketRepository ticketRepo;
        private IViewerRepository viewerRepo;

        MovieList movieList = new MovieList();
        int index = 0;
        string name = "";


        public Cast(string n, int ind)
        {
            actorRepo = new SqlActorRepository(connectionString);
            movieRepo = new SqlMovieRepository(connectionString);
            reviewRepo = new SqlReviewRepository(connectionString);
            showtimeRepo = new SqlShowTimeRepository(connectionString);
            ticketRepo = new SqlTicketRepository(connectionString);
            viewerRepo = new SqlViewerRepository(connectionString);

            InitializeComponent();

            index = ind;
            name = n;

            index = ind;
            name = movieRepo.FetchMovie(ind).Name;
            label1.Text = name;

            IReadOnlyList<Actor> actors = actorRepo.FetchActorOnMovie(ind);
            foreach (Actor a in actors)
            {
                listBox1.Items.Add(a.Name);
            }

        }
    }
}
