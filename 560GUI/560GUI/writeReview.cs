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
    public partial class writeReview : Form
    {
        const string connectionString = @"Data Source=mssql.cs.ksu.edu;Initial Catalog=jamesmmatt;User Id=jamesmmatt;Password=Oscarpatatoe14;";

        private IActorRepository actorRepo;
        private IMovieRepository movieRepo;
        private IReviewRepository reviewRepo;
        private IShowTimeRepository showtimeRepo;
        private ITicketRepository ticketRepo;
        private IViewerRepository viewerRepo;

        Reviews review = new Reviews();
        currentUser cu = new currentUser();

        public writeReview(Reviews r)
        {
            actorRepo = new SqlActorRepository(connectionString);
            movieRepo = new SqlMovieRepository(connectionString);
            reviewRepo = new SqlReviewRepository(connectionString);
            showtimeRepo = new SqlShowTimeRepository(connectionString);
            ticketRepo = new SqlTicketRepository(connectionString);
            viewerRepo = new SqlViewerRepository(connectionString);

            InitializeComponent();

            review = r;
            cu = review.getCurrentUser();
            label1.Text = cu.userName;
            label4.Text = review.getMovieName();
        }

        private void postReviewButton_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Text != "" && textBox1.Text != "")
            {
            
                //Must be able to insert new user first
                Viewer v = viewerRepo.RetrieveViewerOnEmail(cu.userName);
                int index = review.getMovieId();
                try
                {
                    decimal rating = decimal.Parse(textBox1.Text);
                    
                    int low = decimal.Compare(rating, (decimal)1.0);
                    int high = decimal.Compare(rating, (decimal)5.0);

                    string theReview = richTextBox1.Text;
                    if(low != -1 && high != 1)
                    {
                        reviewRepo.CreateReview(v.ViewerId, index, rating, theReview);
                        MessageBox.Show("review written!");
                    }
                    else
                    {
                        MessageBox.Show("Must be inbetween 1.0 and 5.0");
                    }
                    
                }
                catch
                {
                    MessageBox.Show("Must enter decimal number into rating");
                }
            }
            else
            {
                MessageBox.Show("Must write review and rating for the movie");
            }
            
        }
    }
}
