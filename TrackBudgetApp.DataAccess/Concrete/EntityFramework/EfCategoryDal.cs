using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.DataAccess.EntityFramework;
using TrackBudgetApp.DataAccess.Abstract;
using TrackBudgetApp.Entities.Concrete;

namespace TrackBudgetApp.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal:EfEntityRepositoryBase<Category, TrackBudgetAppContext>,ICategoryDal
    {
    }
}
