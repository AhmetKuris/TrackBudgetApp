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
    public partial class MainPage : Form
    {
        private IUserService _userService;
        private ICategoryService _categoryService;
        private ITypeService _typeService;
        public MainPage()
        {
            InitializeComponent();
            _userService = InstanceFactory.GetInstance<IUserService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
            _typeService= InstanceFactory.GetInstance<ITypeService>();
        }




    private void ClearTextboxes()
        {
           tbxTransactionName.Clear();
           tbxTransactionAmount.Clear();
           tbxTransactionDescription.Clear();
           tbxTransactionRepeat.Clear();
        
        }

        private void MainPage_Load(object sender, EventArgs e)
        { 
            LoadCurrentBudgetNow();
            LoadCategories();
            LoadTypes();
        }

       

        private void dateTimePickerCurrentBudgetAfterDate_ValueChanged(object sender, EventArgs e)
        {
            lblCurrentBudgetAfterDateValue.Text =
                _userService.CurrentBudgetShowByTime(dateTimePickerCurrentBudgetAfterDate.Value);

        }

        private void LoadCategories()
        {
            cbxTransactionCategory.DataSource = _categoryService.GetAll();
            cbxTransactionCategory.DisplayMember = "Name";
            cbxTransactionCategory.ValueMember = "Id";
        }

        private void LoadCurrentBudgetNow()
        {
            lblCurrentBudgetNow.Text = _userService.CurrentBudgetShowByTime(DateTime.Now);
        }

        private void LoadTypes()
        {
            cbxTransactionOutcomeIncome.DataSource = _typeService.GetAll();
            cbxTransactionOutcomeIncome.DisplayMember = "Name";
            cbxTransactionOutcomeIncome.ValueMember = "Id";
        }

        private void btnTransactionSubmit_Click(object sender, EventArgs e)
        {
            _userService.SubmitTransaction(new Transaction
            {
                CategoryId = Convert.ToInt32(cbxTransactionCategory.SelectedValue),
                TypeId = Convert.ToInt32(cbxTransactionOutcomeIncome.SelectedValue),
                Name = tbxTransactionName.Text,
                Amount = Convert.ToDecimal(tbxTransactionAmount.Text),
                IssuedTime = DateTime.Now,
                EffectiveTime = dateTimePickerTransactionEffectiveDate.Value,
                RepetitionAfterXDay = Convert.ToInt32(tbxTransactionRepeat.Text),
                Description = tbxTransactionDescription.Text

            });

            LoadCurrentBudgetNow();
            ClearTextboxes();
        }
    }
}
