using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackBudgetApp.WindowsFormsUI
{
    public partial class ReportsPage : Form
    {
        public ReportsPage()
        {
            InitializeComponent();
        }

        private void btnChildFormClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
