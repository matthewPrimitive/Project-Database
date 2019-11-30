using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _560GUI
{
    public partial class Reviews : Form
    {
        MovieList movieList = new MovieList();
        currentUser cu = new currentUser();

        public Reviews(MovieList ml)
        {
            InitializeComponent();
            movieList = ml;

            rUserLabel.Text = movieList.getCurrentUserLabel();
            cu = movieList.getCurrentUser();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var wr = new writeReview();
            wr.Show();
        }
    }
}
