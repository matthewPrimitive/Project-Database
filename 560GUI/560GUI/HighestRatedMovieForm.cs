using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieProject.DataDelegates;
using MovieProject.Models;
using MovieProject;

namespace _560GUI
{
    public partial class HighestRatedMovieForm : Form
    {
        private IHighestRatedMovieRepository repo;


        public HighestRatedMovieForm(string connectionString)
        {
            InitializeComponent();

            repo = new SqlHighestRatedMovieRepository(connectionString);
        }

        private void uxSearch_Click(object sender, EventArgs e)
        {
            string start = uxStartDatePicker.Value.ToString("yyyy-MM-dd");
            string end = uxEndDatePicker.Value.ToString("yyyy-MM-dd");

            IReadOnlyList<Report1Object> list = repo.RatingOverTime(start, end);

            foreach(Report1Object obj in list)
            {
                uxHighestRatedMovie.Items.Insert(0, obj.Name);
                uxHighestRatedMovie.Items.Insert(1, obj.Rating.ToString());
            }
        }
    }
}
