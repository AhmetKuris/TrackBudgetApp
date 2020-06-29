using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackBudgetApp.Business.Abstract;
using TrackBudgetApp.DataAccess.Abstract;
using TrackBudgetApp.Entities.Concrete;

namespace TrackBudgetApp.Business.Concrete
{
    public class TypeManager:ITypeService
    {
        private ITypeDal _typeDal;

        public TypeManager(ITypeDal typeDal)
        {
            _typeDal = typeDal;
        }

        public List<TypeEntity> GetAll()
        {
          return  _typeDal.GetList().Select(t => new TypeEntity
            {
                Id = t.Id,
                Name = t.Name
            }).ToList();
        }
    }
}
