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
    public partial class createAccount : Form
    {
        Form1 mainForm = new Form1();

        const string connectionString = @"Data Source=mssql.cs.ksu.edu;Initial Catalog=jamesmmatt;User Id=jamesmmatt;Password=Oscarpatatoe14;";
        private IViewerRepository viewerRepo;

        public createAccount()
        {
            InitializeComponent();
            viewerRepo = new SqlViewerRepository(connectionString);

        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string name = textBox2.Text;
            string gender = "Male";
            if(checkBox2.Checked)
            {
                gender = "Female";
            }
            string asString = dateTimePicker1.Value.ToString("dd MMMM yyyy hh:mm:ss tt");

            try
            {
                Viewer v = viewerRepo.RetrieveViewerOnEmail(user);
                MessageBox.Show("Email is already in the database");
            }
            catch
            {
                mainForm.theUser = new currentUser(user);
                mainForm.changeLabel(mainForm.theUser.userName);

                string[] username = user.Split('@');
                string UsernameAsString = username.ToString();

                viewerRepo.CreateViewer(gender, user, asString, UsernameAsString, name);
                MessageBox.Show("new user created!");
                currentUser newUser = new currentUser(user);
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
