using SilvRestaurant.Core.Application.ViewModels.Ingredient;
using System.Globalization;

namespace SilvRestaurant.Core.Application.ViewModels.Dishes
{
    public class DisheViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public int AmountOfPeople { get; set; }
        public List<string>? Ingredients { get; set; }
        public string? Category { get; set; }
    }
}
