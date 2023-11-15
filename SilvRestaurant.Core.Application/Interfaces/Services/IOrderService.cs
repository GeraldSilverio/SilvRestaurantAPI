using SilvRestaurant.Core.Application.ViewModels.Order;
using SilvRestaurant.Core.Domain.Entities;

namespace SilvRestaurant.Core.Application.Interfaces.Services
{
    public interface IOrderService : IGenericService<SaveOrderViewModel, OrderViewModel, Order>
    {
        Task<OrderViewModel> GetOrderById(int id);
        Task<List<OrderViewModel>> GetOrderByIdTable(int idTable);
        Task UpdateDishes(List<int> dishes,int id);
        Task CompletedOrder(int id);




    }
}
