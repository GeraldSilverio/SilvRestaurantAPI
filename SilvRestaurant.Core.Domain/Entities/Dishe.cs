using SilvRestaurant.Core.Domain.Commons;

namespace SilvRestaurant.Core.Domain.Entities
{
    public class Dishe : AuditableBaseEntity
    {
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public int AmountOfPeople { get; set; }
        public CategoryOfDishe Category { get; set; }
        public int IdCategory{ get; set; }

        public ICollection<DisheIngredient> DisheIngredients { get; set; }
    }
}
