using SilvRestaurant.Core.Application.ViewModels.Ingredient;

namespace SilvRestaurant.Core.Application.ViewModels.Dishes
{
    public class DisheViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public int AmountOfPeople { get; set; }
        public List<IngredientViewModel>? Ingredients { get; set; }
        public string? Category { get; set; }
    }
}
