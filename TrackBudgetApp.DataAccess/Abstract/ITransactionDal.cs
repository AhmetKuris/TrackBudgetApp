using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.DataAccess;
using TrackBudgetApp.Entities.Concrete;

namespace TrackBudgetApp.DataAccess.Abstract
{
    public interface ITransactionDal:IEntityRepository<Transaction>
    {
    }
}
