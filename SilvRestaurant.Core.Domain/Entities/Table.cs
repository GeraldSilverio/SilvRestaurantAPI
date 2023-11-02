using SilvRestaurant.Core.Domain.Commons;

namespace SilvRestaurant.Core.Domain.Entities
{
    public class Table:AuditableBaseEntity
    {
        public int AmountOfPeople {  get; set; }
        public string Description { get; set; } = null!;
        public int StatusOfTable { get; set; }
    }
}
