using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackBudgetApp.Entities.Concrete;

namespace TrackBudgetApp.DataAccess.Concrete.EntityFramework.Mappings
{
    public class TransactionMap:EntityTypeConfiguration<Transaction>
    {
        public TransactionMap()
        {
            ToTable(@"Transactions", @"dbo");
            HasKey(x => x.Id);

            Property(x => x.UserId).HasColumnName("UserId");
            Property(x => x.CategoryId).HasColumnName("CategoryId");
            Property(x => x.TypeId).HasColumnName("TypeId");
            Property(x => x.Name).HasColumnName("Name");
            Property(x => x.Amount).HasColumnName("Amount");
            Property(x => x.IssuedTime).HasColumnName("IssuedTime");
            Property(x => x.EffectiveTime).HasColumnName("EffectiveTime");
            Property(x => x.RepetitionAfterXDay).HasColumnName("RepetitionAfterXDay");
            Property(x => x.Description).HasColumnName("Description");

        }
    }
}
