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
    public partial class MovieList : Form
    {

        const string connectionString = @"Data Source=mssql.cs.ksu.edu;Initial Catalog=jamesmmatt;User Id=jamesmmatt;Password=Choppers7;";

        private IActorRepository actorRepo;
        private IMovieRepository movieRepo;
        private IReviewRepository reviewRepo;
        private IShowTimeRepository showtimeRepo;
        private ITicketRepository ticketRepo;
        private IViewerRepository viewerRepo;

        Form1 mainForm = new Form1();
        currentUser cu = new currentUser();

        public MovieList()
        {
            actorRepo = new SqlActorRepository(connectionString);
            movieRepo = new SqlMovieRepository(connectionString);
            reviewRepo = new SqlReviewRepository(connectionString);
            showtimeRepo = new SqlShowTimeRepository(connectionString);
            ticketRepo = new SqlTicketRepository(connectionString);
            viewerRepo = new SqlViewerRepository(connectionString);


        }

        public currentUser getCurrentUser()
        {
            return cu;
        }

        public string getCurrentUserLabel()
        {
            return mlSignedinLabel.Text;
        }

        public MovieList(Form1 f1)
        {
            InitializeComponent();
            mainForm = f1;

            mlSignedinLabel.Text = mainForm.getCurrentUserLabel();
            cu = mainForm.getCurrentUser();

            actorRepo = new SqlActorRepository(connectionString);
            movieRepo = new SqlMovieRepository(connectionString);
            reviewRepo = new SqlReviewRepository(connectionString);
            showtimeRepo = new SqlShowTimeRepository(connectionString);
            ticketRepo = new SqlTicketRepository(connectionString);
            viewerRepo = new SqlViewerRepository(connectionString);

            IReadOnlyList<Movie> m = movieRepo.RetrieveMovies();
            foreach (Movie movie in m)
            {
                listBox1.Items.Add(movie.Name);
            }

            //populate listbox
        }

        private void reviewButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                int ind = listBox1.SelectedIndex;
                var r = new Reviews(this , ind+1);
                r.Show();
            }
            else
            {
                MessageBox.Show("Select a movie to see it's reviews");
            }
            
        }

        private void castButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                int ind = listBox1.SelectedIndex;
                string n = listBox1.SelectedItem.ToString();
                var c = new Cast(n, ind + 1);
                c.Show();
            }
            else
            {
                MessageBox.Show("Select a movie to see it's reviews");
            }
        }
    }
}
