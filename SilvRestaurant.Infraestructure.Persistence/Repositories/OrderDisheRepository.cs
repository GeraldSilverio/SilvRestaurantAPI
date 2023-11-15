using SilvRestaurant.Core.Application.Interfaces.Repositories;
using SilvRestaurant.Core.Domain.Entities;
using SilvRestaurant.Infraestructure.Persistence.Context;

namespace SilvRestaurant.Infraestructure.Persistence.Repositories
{
    public class OrderDisheRepository : GenericRepositoryAsync<OrderDishes>, IOrderDisheRepository
    {
        private readonly ApplicationContext _dbContext;
        public OrderDisheRepository(ApplicationContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task ClearOrderDishe(int idOrder)
        {
            var orderDishes = _dbContext.OrderDishes.Where(x => x.IdDishe == idOrder);

            foreach (var order in orderDishes)
            {
                _dbContext.Remove(order);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
