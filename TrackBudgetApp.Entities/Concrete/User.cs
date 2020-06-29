using DevFramework.Core.Entities;

namespace TrackBudgetApp.Entities.Concrete
{
    public class User:IEntity
    {
        public int Id { get; set; }
        public string UserNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}