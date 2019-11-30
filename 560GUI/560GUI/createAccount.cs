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
    public partial class createAccount : Form
    {
        public createAccount()
        {
            InitializeComponent();
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pw1 = textBox2.Text;
            string pw2 = textBox3.Text;

            if (user == null || user == "")
                MessageBox.Show("no Username given");

            else if (pw1 == null || pw1 == "")
                MessageBox.Show("no Password given");

            else if(!pw1.Equals(pw2))
                MessageBox.Show("must enter password in twice");

            else
            {
                MessageBox.Show("new user created!");

                //create new user object
                currentUser newUser = new currentUser(user, pw1);
                this.Close();
            }

        }
    }
}
