using SilvRestaurant.Core.Domain.Entities;

namespace SilvRestaurant.Core.Application.Interfaces.Repositories
{
    public interface IOrderDisheRepository:IGenericRepositoryAsync<OrderDishes>
    {
        Task ClearOrderDishe(int idOrder);
    }
}
