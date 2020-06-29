using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using TrackBudgetApp.Business.Abstract;
using TrackBudgetApp.Business.Concrete;
using TrackBudgetApp.DataAccess.Abstract;
using TrackBudgetApp.DataAccess.Concrete.EntityFramework;

namespace TrackBudgetApp.Business.DependencyResolvers.Ninject
{
    class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IUserService>().To<UserManager>().InSingletonScope();
            Bind<IUserDal>().To<EfUserDal>().InSingletonScope();

            Bind<ITransactionDal>().To<EfTransactionDal>().InSingletonScope();


            Bind<ICategoryService>().To<CategoryManager>();
            Bind<ICategoryDal>().To<EfCategoryDal>().InSingletonScope();


            Bind<ITypeService>().To<TypeManager>().InSingletonScope();
            Bind<ITypeDal>().To<EfTypeDal>().InSingletonScope();


        }
    }
}
