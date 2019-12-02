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
    public partial class MostViewedMovieForm : Form
    {
        private IMostViewedMovieRepository repo;

        public MostViewedMovieForm(string connectionString)
        {
            InitializeComponent();

            repo = new SqlMostViewedMovieRepository(connectionString);
        }

        private void uxSearch_Click(object sender, EventArgs e)
        {
            string start = uxStartDatePicker.Value.ToString("yyyy-MM-dd");
            string end = uxEndDatePicker.Value.ToString("yyyy-MM-dd");

            IReadOnlyList<Report2Object> list = repo.MostViewed(start, end);

            foreach (Report2Object obj in list)
            {
                uxMostViewed.Items.Insert(0, obj.Name);
                uxMostViewed.Items.Insert(1, obj.NumberOfViewers.ToString());
            }
        }
    }
}
