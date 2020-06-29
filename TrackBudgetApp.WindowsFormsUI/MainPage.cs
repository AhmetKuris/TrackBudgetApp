using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackBudgetApp.Business.Abstract;
using TrackBudgetApp.Business.DependencyResolvers.Ninject;

namespace TrackBudgetApp.WindowsFormsUI
{
    public partial class MainPage : Form
    {
        private IUserService _userService;
        public MainPage()
        {
            InitializeComponent();
            _userService = InstanceFactory.GetInstance<IUserService>();


        }

        private void btnChildFormClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
           lblCurrentBudgetNow.Text= _userService.CurrentBudgetShowByTime(DateTime.Now);
        }
    }
}
