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
    public partial class StartingPage : Form
    {
        public StartingPage()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void StartingPage_Load(object sender, EventArgs e)
        {

        }

        private void CustomizeDesign()
        {

        }

        
        //For child form container
        private Form activeForm = null;
        public void OpenChildForm(Form childForm)
        {
            if(activeForm!=null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();


        }

        private void btnMainPage_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MainPage());
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Categories());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReportsPage());

        }

        private void btnPlanner_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PlannerPage());
        }
        private void btnFamilyAccount_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FamilyAccountPage());

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SettingsPage());

        }



        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage loginPage = new LoginPage();
            loginPage.ShowDialog();
            this.Close();
        }

     
    }
}
