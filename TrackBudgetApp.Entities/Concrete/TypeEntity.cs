using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.Entities;

namespace TrackBudgetApp.Entities.Concrete
{
    [Table("Types")]
    public class TypeEntity:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
