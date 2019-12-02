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
    public partial class writeReview : Form
    {
        Reviews review = new Reviews();
        currentUser cu = new currentUser();

        public writeReview(Reviews r)
        {
            InitializeComponent();

            review = r;
            cu = review.getCurrentUser();
            label1.Text = cu.userName;
            label4.Text = review.getMovieName();
        }

        private void postReviewButton_Click(object sender, EventArgs e)
        {
            //Must be able to insert new user first
        }
    }
}
