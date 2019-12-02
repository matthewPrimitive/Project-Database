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
    public partial class HighestRatedActorForm : Form
    {
        private IHighestRatedActorRepository repo;

        public HighestRatedActorForm(string connectionString)
        {
            InitializeComponent();
            repo = new SqlHighestRatedActorRepository(connectionString);

            IReadOnlyList<Report4Object> list = repo.HighestRatedActor();

            foreach(Report4Object obj in list)
            {              
                ListViewItem item = new ListViewItem(obj.Name);
                item.SubItems.Add(obj.OverallRating.ToString());
                uxActorList.Items.Add(item);
            }
        }
    }
}
