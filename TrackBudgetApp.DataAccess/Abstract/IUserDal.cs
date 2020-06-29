using DevFramework.Core.DataAccess;
using TrackBudgetApp.Entities.Concrete;

namespace TrackBudgetApp.DataAccess.Abstract
{
    public interface IUserDal:IEntityRepository<User>
    {
        
    }
}