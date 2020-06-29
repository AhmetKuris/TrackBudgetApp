using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.Entities;

namespace TrackBudgetApp.Entities.Concrete
{
    public class Transaction:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int  CategoryId { get; set; }
        public string Name { get; set; }
        public int TypeId { get; set; }
        public decimal Amount { get; set; }
        public DateTime IssuedTime { get; set; }
        public DateTime EffectiveTime { get; set; }
        public int RepetitionAfterXDay { get; set; }
        public string Description { get; set; }
    }
}
