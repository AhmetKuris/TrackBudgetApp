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
    public partial class SignUpPage : Form
    {
        private IUserService _userService;
        public SignUpPage()
        {
            InitializeComponent();
            _userService = InstanceFactory.GetInstance<IUserService>();

        }

        private void btnLoginSignUpPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage loginPage=new LoginPage();
            loginPage.ShowDialog();
            this.Close();
        }

        private void SignUpPage_Load(object sender, EventArgs e)
        {
            

        }

        private void ClearTextBoxes()
        {
            tbxNameSignUpPage.Clear();
            tbxSurnameSignUpPage.Clear();
            tbxEmailSignUpPage.Clear();
            tbxPasswordSignUpPage.Clear();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

                    try
                    {

                        switch (_userService.SignUp(new User
                        {
                            FirstName = tbxNameSignUpPage.Text,
                            LastName = tbxSurnameSignUpPage.Text,
                            Email = tbxEmailSignUpPage.Text,
                            Password = tbxPasswordSignUpPage.Text   
                        }))
                        {
                            case "Added":
                                MessageBox.Show("User added succesfully! Please login to proceed.");
                                ClearTextBoxes();
                                break;
                            case "AlreadyExists":
                                MessageBox.Show("Email already exits! Please use another one.");
                                ClearTextBoxes();
                                break;
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                        
                    }
        }

      
    }
}
