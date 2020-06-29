using System.Data.Entity;
using TrackBudgetApp.Entities.Concrete;

namespace TrackBudgetApp.DataAccess.Concrete.EntityFramework
{
    public class TrackBudgetAppContext:DbContext
    {
        public TrackBudgetAppContext()
        {
            Database.SetInitializer<TrackBudgetAppContext>(null);
        }
        
        public DbSet<User> Users { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TypeEntity> Types { get; set; }
        public DbSet<Category> Categories { get; set; }
        //
        
        
    }
}