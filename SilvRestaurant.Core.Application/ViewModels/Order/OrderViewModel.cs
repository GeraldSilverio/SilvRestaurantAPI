using SilvRestaurant.Core.Application.ViewModels.Dishes;
using SilvRestaurant.Core.Domain.Entities;

namespace SilvRestaurant.Core.Application.ViewModels.Order
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public int IdTable { get; set; }
        public List<DisheDataViewModel> Dishe { get; set; }
        public decimal SubTotal { get; set; }
        public string Status {  get; set; }
    }
}
