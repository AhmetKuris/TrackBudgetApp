using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackBudgetApp.Business.Abstract;
using TrackBudgetApp.Business.Properties;
using TrackBudgetApp.DataAccess.Abstract;
using TrackBudgetApp.Entities.Concrete;

namespace TrackBudgetApp.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;
        private IUserDal _userDal;
        private string _loggedInUserEmail;
        private int _loggedInUserId;

        public CategoryManager(ICategoryDal categoryDal, IUserDal userDal)
        {
            _categoryDal = categoryDal;
            _userDal = userDal;
            _loggedInUserEmail = Settings.Default.LoggedInUserEmail;

            _loggedInUserId = GenerateUserIdFromEmail();
        }

        public List<Category> GetAll()
        {
           return  _categoryDal.GetList(c=>c.UserId==_loggedInUserId).Select(c=>new Category
           {
               Id = c.Id,
               UserId = c.UserId,
               Name = c.Name

           }).ToList();
        }

        private int GenerateUserIdFromEmail()
        {
            User user = _userDal.Get(u => u.Email == _loggedInUserEmail);

            return user.Id;
        }
    }
}
