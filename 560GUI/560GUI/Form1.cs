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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // dumby data to ensure its making the moves
            dropList.Items.Add("Movie 1");
            dropList.Items.Add("Movie 2");
            dropList.Items.Add("Movie 3");

            showtimeDropbox.Items.Add("Time 1");
            showtimeDropbox.Items.Add("Time 2");
            showtimeDropbox.Items.Add("Time 3");
            // listCollection.Itmes.Add(databaseMovies) // from the data base add the current movies showing  into the drop list
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
            }  

            catch
            {
                // MessageBox.Show("Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            listBox1.Items.Add(movieTitle);

            //this will populate the listbox with the movie database information for the specific movie
            
        }

        private void showtimeSearch_Click(object sender, EventArgs e)
        {
            // this is just populating the list box with the dumby data for now
            object selectedItem = showtimeDropbox.SelectedItem;
            string movieTitle = selectedItem.ToString();
            listBox1.Items.Add(movieTitle);
            // this will populate all the movies that have to do with the show time
        }
    }
}
