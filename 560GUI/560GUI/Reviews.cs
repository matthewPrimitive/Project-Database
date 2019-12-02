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
    public partial class Reviews : Form
    {
        const string connectionString = @"Data Source=mssql.cs.ksu.edu;Initial Catalog=jamesmmatt;User Id=jamesmmatt;Password=Oscarpatatoe14;";

        private IActorRepository actorRepo;
        private IMovieRepository movieRepo;
        private IReviewRepository reviewRepo;
        private IShowTimeRepository showtimeRepo;
        private ITicketRepository ticketRepo;
        private IViewerRepository viewerRepo;

        MovieList movieList = new MovieList();
        currentUser cu = new currentUser();
        int index = 0;

        public Reviews(MovieList ml , int i)
        {
            actorRepo = new SqlActorRepository(connectionString);
            movieRepo = new SqlMovieRepository(connectionString);
            reviewRepo = new SqlReviewRepository(connectionString);
            showtimeRepo = new SqlShowTimeRepository(connectionString);
            ticketRepo = new SqlTicketRepository(connectionString);
            viewerRepo = new SqlViewerRepository(connectionString);

            InitializeComponent();
            movieList = ml;

            rUserLabel.Text = movieList.getCurrentUserLabel();
            cu = movieList.getCurrentUser();
            index = i;

            
            IReadOnlyList<Review> reviews = reviewRepo.FetchMovieReviews(i);
            foreach (Review r in reviews)
            {
                listBox1.Items.Add(r);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var wr = new writeReview();
            wr.Show();
        }
    }
}
