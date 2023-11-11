namespace SilvRestaurant.Core.Application.ViewModels.Table
{
    public class TableViewModel
    {
        public int Id { get; set; }
        public int AmountOfPeople { get; set; }
        public string Description { get; set; } = null!;
        public string StatusOfTable { get; set; } = null!;
    }
}
