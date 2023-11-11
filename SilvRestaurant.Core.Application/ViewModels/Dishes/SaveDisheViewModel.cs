namespace SilvRestaurant.Core.Application.ViewModels.Dishes
{
    public class SaveDisheViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public int AmountOfPeople { get; set; }
        public List<int>? IdIngredients { get; set; }
        public int IdCategory { get; set; }
    }
}
