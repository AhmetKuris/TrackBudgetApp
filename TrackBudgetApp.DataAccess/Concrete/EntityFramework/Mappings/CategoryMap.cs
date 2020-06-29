using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackBudgetApp.Entities.Concrete;

namespace TrackBudgetApp.DataAccess.Concrete.EntityFramework.Mappings
{
    public class CategoryMap:EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            ToTable(@"Categories", @"dbo");
            HasKey(x => x.Id);

            Property(x => x.UserId).HasColumnName("UserId");
            Property(x => x.Name).HasColumnName("Name");
        }



    }
}
