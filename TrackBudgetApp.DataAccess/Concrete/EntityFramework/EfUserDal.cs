using DevFramework.Core.DataAccess.EntityFramework;
using TrackBudgetApp.DataAccess.Abstract;
using TrackBudgetApp.Entities.Concrete;

namespace TrackBudgetApp.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal:EfEntityRepositoryBase<User, TrackBudgetAppContext >,IUserDal
    {
        
    }
}