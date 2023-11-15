using System.Text.Json.Serialization;

namespace SilvRestaurant.Core.Application.ViewModels.Order
{
    public class SaveOrderViewModel
    {
        [JsonIgnore]
        public int Id { get; set; }
        public int IdTable { get; set; }
        [JsonIgnore]
        public decimal SubTotal { get; set; }
        public List<int> Dishes { get; set; }
        [JsonIgnore]
        public string? Status { get; set; }
    }
}
