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
    public partial class BestTimeForm : Form
    {
        private IBestTimeRepository repo;

        public BestTimeForm(string connectionString)
        {
            InitializeComponent();
            repo = new SqlBestTimeRepository(connectionString);

            //get information
            IReadOnlyList<Report3Object> list = repo.BestTime();

            foreach(Report3Object obj in list)
            {                
                uxBestTime.Items.Insert(0, obj.Time);
                uxBestTime.Items.Insert(1, obj.Day);
                uxBestTime.Items.Insert(2, obj.NumberOfViewers.ToString());
            }
        }
    }
}
