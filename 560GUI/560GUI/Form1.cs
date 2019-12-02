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

namespace _560GUI
{
    public partial class Form1 : Form
    {
        const string connectionString = "Server=mssql.cs.ksu.edu;Database=tholt15;User Id=tholt15;Password=TJholt1544";

        private IActorRepository actorRepo;
        private IMovieRepository movieRepo;
        private IReviewRepository reviewRepo;
        private IShowTimeRepository showtimeRepo;
        private ITicketRepository ticketRepo;
        private IViewerRepository viewerRepo;

        public currentUser theUser { get; set; }

        public currentUser getCurrentUser()
        {
            return theUser;
        }

        public Form1()
        {
            InitializeComponent();
            // setup repos
            actorRepo = new SqlActorRepository(connectionString);
            movieRepo = new SqlMovieRepository(connectionString);
            reviewRepo = new SqlReviewRepository(connectionString);
            showtimeRepo = new SqlShowTimeRepository(connectionString);
            ticketRepo = new SqlTicketRepository(connectionString);
            viewerRepo = new SqlViewerRepository(connectionString);


            // dumby data to ensure its making the moves
            dropList.Items.Add("Movie 1");
            dropList.Items.Add("Movie 2");
            dropList.Items.Add("Movie 3");

            showtimeDropbox.Items.Add("Time 1");
            showtimeDropbox.Items.Add("Time 2");
            showtimeDropbox.Items.Add("Time 3");
            // listCollection.Itmes.Add(databaseMovies) // from the data base add the current movies showing  into the drop list



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //populate listView
            movieListbox.Items.Add("Movie 1");
            movieListbox.Items.Add("Movie 2");
            movieListbox.Items.Add("Movie 3");

        }



        private void dropList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //empty
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // this is just populating the list box with the dumby data for now
            object selectedInd = dropList.SelectedItem;
            string movieTitle = selectedInd.ToString();
            movieListbox.Items.Clear();
            movieListbox.Items.Add(movieTitle);

            //this will populate the listbox with the movie database information for the specific movie
            
        }

        private void showtimeSearch_Click(object sender, EventArgs e)
        {
            // this is just populating the list box with the dumby data for now
            object selectedItem = showtimeDropbox.SelectedItem;
            string movieTitle = selectedItem.ToString();
            //listBox1.Items.Add(movieTitle);
            // this will populate all the movies that have to do with the show time
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var lf = new loginForm(this);
            lf.Show();
            //changeLabel(theUser.userName);
        }

        public void changeLabel(string s)
        {
            currentUserLabel.Text = s;
        }

        private void movieDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ml = new MovieList(this);
            ml.Show();
        }

        
        private void buyButton_Click(object sender, EventArgs e)
        {
            
            if(movieListbox.SelectedItem != null)
            {
                string ticketMessage = "Ticket for " + movieListbox.SelectedItem.ToString() + " purchased!\n Thank you for your order!";

                MessageBox.Show(ticketMessage);
            }
            else
            {
                MessageBox.Show("No movie selected");
            }
            
        }

        private void movieListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //whatever movie is selected will print out the showtimes in the other listbox
            int i = 0;
            int index = movieListbox.SelectedIndex;
            while(i < 0)
            {
                //showtimeListBox.Items.Add(movieListbox.)
            }
        }

        public string getCurrentUserLabel()
        {
            return currentUserLabel.Text;
        }
    }
}
