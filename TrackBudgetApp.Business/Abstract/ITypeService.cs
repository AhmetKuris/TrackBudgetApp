using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackBudgetApp.Entities.Concrete;

namespace TrackBudgetApp.Business.Abstract
{
    public interface ITypeService
    {
        List<TypeEntity> GetAll();
    }
}
