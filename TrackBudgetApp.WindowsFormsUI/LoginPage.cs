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
using TrackBudgetApp.Entities.Concrete;

namespace TrackBudgetApp.WindowsFormsUI
{
    public partial class LoginPage : Form
    {
        private IUserService _userService;

        public LoginPage()
        {
            InitializeComponent();
            _userService = InstanceFactory.GetInstance<IUserService>();

        }

        private void btnSignUpLoginPage_Click(object sender, EventArgs e)
        {   
            this.Hide();
            SignUpPage signUpPage=new SignUpPage();
            signUpPage.ShowDialog();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
                    try
                    {
                        switch (_userService.Login(new User
                        {
                            Email = tbxEmailLoginPage.Text,
                            Password = tbxPasswordLoginPage.Text
                        }))

                        {
                            case "True":
                                this.Hide();
                                StartingPage startingPage = new StartingPage();
                                startingPage.ShowDialog();
                                this.Close();
                                break;
                            case "FalsePassword":
                                MessageBox.Show("Wrong password! Please try again.");
                                break;
                            case "FalseUser":
                                MessageBox.Show("Couldn't find the user. Please sign up.");
                                break;

                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                
               
            
            
          
            

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
