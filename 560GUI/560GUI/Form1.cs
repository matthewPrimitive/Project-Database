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
    public partial class Form1 : Form
    {
        const string connectionString = @"Data Source=mssql.cs.ksu.edu;Initial Catalog=jamesmmatt;User Id=jamesmmatt;Password=Oscarpatatoe14;";

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

            
            IReadOnlyList<Movie> m = movieRepo.RetrieveMovies();

            foreach (Movie movie in m)
            {
                dropList.Items.Add(movie.Name);
            }

            showtimeDropbox.Items.Add("09:30:00");
            showtimeDropbox.Items.Add("13:00:00");
            showtimeDropbox.Items.Add("17:30:00");
            // listCollection.Itmes.Add(databaseMovies) // from the data base add the current movies showing  into the drop list



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IReadOnlyList<Movie> m = movieRepo.RetrieveMovies();
            foreach(Movie movie in m)
            {
                movieListbox.Items.Add(movie.Name);
            }
            //IReadOnlyList<Movie> m = movieRepo.RetrieveMovies();
            


            //populate listView

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
            if (movieListbox.SelectedItem != null && showtimeListBox != null)
            {
                object selectedItem = showtimeDropbox.SelectedItem;
                string movieTitle = selectedItem.ToString();
                showtimeListBox.Items.Clear();

                string movieName = movieListbox.SelectedItem.ToString();
                IReadOnlyList<Movie> m = movieRepo.RetrieveMovies();
                Movie selectedMovie = null;
                foreach (Movie movie in m)
                {
                    if (movie.Name.Equals(movieName))
                    {
                        selectedMovie = movie;
                        break;
                    }
                }

                IReadOnlyList<ShowTime> showtimes = showtimeRepo.RetrieveMovieShowTime(selectedMovie.MovieId);

                //showtimerepo.retrievemovieshowtime
                foreach (ShowTime sh in showtimes)
                {
                    string time = sh.Time;
                    if (selectedItem.Equals(time))
                    {
                        showtimeListBox.Items.Add(sh);

                    }

                }
            }
                // this is just populating the list box with the dumby data for now
            
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
            
            if(movieListbox.SelectedItem != null && showtimeListBox != null)
            {
                string movie = movieListbox.SelectedItem.ToString();
                string full = showtimeListBox.SelectedItem.ToString();
                //string time = 


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
            showtimeListBox.Items.Clear();
            //whatever movie is selected will print out the showtimes in the other listbox
            int i = 0;
            int index = movieListbox.SelectedIndex;
            string movieName = movieListbox.SelectedItem.ToString();
            IReadOnlyList<Movie> m = movieRepo.RetrieveMovies();
            Movie selectedMovie = null;
            foreach(Movie movie in m)
            {
                if (movie.Name.Equals(movieName))
                {
                    selectedMovie = movie;
                    break;
                }
            }
            
            IReadOnlyList<ShowTime> showtimes= showtimeRepo.RetrieveMovieShowTime(selectedMovie.MovieId);

            //showtimerepo.retrievemovieshowtime
            foreach(ShowTime sh in showtimes)
            {
                showtimeListBox.Items.Add(sh);
                
            }
            
        }

        public string getCurrentUserLabel()
        {
            return currentUserLabel.Text;
        }

        private void ux_BestTimeButton_Click(object sender, EventArgs e)
        {
            var btf = new BestTimeForm(connectionString);
            btf.Show();
        }

        private void ux_HighestRatedActors_Click(object sender, EventArgs e)
        {
            var hraf = new HighestRatedActorForm(connectionString);
            hraf.Show();
        }

        private void ux_MostViewedMovies_Click(object sender, EventArgs e)
        {
            var mvmf = new MostViewedMovieForm(connectionString);
            mvmf.Show();
        }

        private void ux_RatingOverTime_Click(object sender, EventArgs e)
        {
            var hrmf = new HighestRatedMovieForm(connectionString);
            hrmf.Show();
        }
    }
}
