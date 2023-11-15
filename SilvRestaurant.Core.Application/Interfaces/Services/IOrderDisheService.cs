using SilvRestaurant.Core.Application.ViewModels.OrderDishe;
using SilvRestaurant.Core.Domain.Entities;

namespace SilvRestaurant.Core.Application.Interfaces.Services
{
    public interface IOrderDisheService:IGenericService<SaveOrderDisheViewModel,OrderDisheViewModel,OrderDishes>
    {
        Task ClearOrderDishe(int idOrder);
    }
}
