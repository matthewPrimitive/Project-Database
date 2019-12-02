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
using System.Text;

namespace _560GUI
{
    public partial class loginForm : Form
    {
        Form1 mainForm = new Form1();

        const string connectionString = @"Data Source=mssql.cs.ksu.edu;Initial Catalog=jamesmmatt;User Id=jamesmmatt;Password=Oscarpatatoe14;";

        private IActorRepository actorRepo;
        private IMovieRepository movieRepo;
        private IReviewRepository reviewRepo;
        private IShowTimeRepository showtimeRepo;
        private ITicketRepository ticketRepo;
        private IViewerRepository viewerRepo;

        public loginForm(Form1 mf)
        {
            InitializeComponent();
            mainForm = mf;
            actorRepo = new SqlActorRepository(connectionString);
            movieRepo = new SqlMovieRepository(connectionString);
            reviewRepo = new SqlReviewRepository(connectionString);
            showtimeRepo = new SqlShowTimeRepository(connectionString);
            ticketRepo = new SqlTicketRepository(connectionString);
            viewerRepo = new SqlViewerRepository(connectionString);
        }

        private void finalLoginButton_Click(object sender, EventArgs e)
        {
            string user = "";

            user = userTextBox.Text.ToLower();
                
            try
            {
                Viewer v = viewerRepo.RetrieveViewerOnEmail(user);
                string[] username = user.Split('@');
                mainForm.theUser = new currentUser(username[0]);
                mainForm.changeLabel(mainForm.theUser.userName);
            }
            catch
            {
                MessageBox.Show("Email not in database try again.");
            }

            //bring in table and check if there's an account matching these

            //create new user object to have as a variable?


            this.Close();
        }

        private void createAccountLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var ca = new createAccount();
            ca.Show();
        }
    }
}
