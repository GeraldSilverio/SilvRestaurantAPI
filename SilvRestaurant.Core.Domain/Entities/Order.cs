using SilvRestaurant.Core.Domain.Commons;

namespace SilvRestaurant.Core.Domain.Entities
{
    public class Order : AuditableBaseEntity
    {
        public decimal SubTotal { get; set; }
        public int Status { get; set; }
        public ICollection<OrderDishes> OrderDishes { get; set; }
        public Table Table { get; set; }
        public int IdTable { get; set; }
    }
}
