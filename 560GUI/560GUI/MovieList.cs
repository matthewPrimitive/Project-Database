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
    public partial class MovieList : Form
    {
        Form1 mainForm = new Form1();
        currentUser cu = new currentUser();

        public MovieList()
        {

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

            //populate listbox
        }

        private void reviewButton_Click(object sender, EventArgs e)
        {
            var r = new Reviews(this);
            r.Show();
        }
    }
}
