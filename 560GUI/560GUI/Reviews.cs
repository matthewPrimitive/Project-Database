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
        const string connectionString = @"Data Source=mssql.cs.ksu.edu;Initial Catalog=jamesmmatt;User Id=jamesmmatt;Password=Choppers7;";

        private IActorRepository actorRepo;
        private IMovieRepository movieRepo;
        private IReviewRepository reviewRepo;
        private IShowTimeRepository showtimeRepo;
        private ITicketRepository ticketRepo;
        private IViewerRepository viewerRepo;

        MovieList movieList = new MovieList();
        currentUser cu = new currentUser();
        int index = 0;
        string movieName = "";

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
            movieName = movieRepo.FetchMovie(i).Name;
            
            IReadOnlyList<Review> reviews = reviewRepo.FetchMovieReviews(i);
            foreach (Review r in reviews)
            {
                listBox1.Items.Add(r.ToString());
            }
            movieNameLabel.Text = movieName;
            
        }

        public currentUser getCurrentUser()
        {
            return cu;
        }

        public Reviews()
        {

        }

        public string getMovieName()
        {
            return movieName;
        }

        public int getMovieId()
        {
            return index;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cu != null)
            {
                var wr = new writeReview(this);
                wr.FormClosed += new FormClosedEventHandler(this.writeReview_FormClosed);
                wr.Show();
               
            }
            else
            {
                MessageBox.Show("Must be signed in to write review");
            }
        }

        private void writeReview_FormClosed(Object sender, FormClosedEventArgs e)
        {
            listBox1.Items.Clear();
            IReadOnlyList<Review> reviews = reviewRepo.FetchMovieReviews(index);
            foreach (Review r in reviews)
            {
                listBox1.Items.Add(r.ToString());
            }
        }
    }
}
