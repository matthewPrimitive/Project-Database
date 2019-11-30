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
    public partial class loginForm : Form
    {
        Form1 mainForm = new Form1();

        public loginForm(Form1 mf)
        {
            InitializeComponent();
            mainForm = mf;
        }

        private void finalLoginButton_Click(object sender, EventArgs e)
        {
            string user = userTextBox.Text;
            string pw = pwTextBox.Text;

            //bring in table and check if there's an account matching these

            //create new user object to have as a variable?
            mainForm.theUser = new currentUser(user, pw);
            mainForm.changeLabel(mainForm.theUser.userName);

            this.Close();
        }

        private void createAccountLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var ca = new createAccount();
            ca.Show();
        }
    }
}
