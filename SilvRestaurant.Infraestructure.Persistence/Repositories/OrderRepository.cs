using SilvRestaurant.Core.Application.Interfaces.Repositories;
using SilvRestaurant.Core.Domain.Entities;
using SilvRestaurant.Infraestructure.Persistence.Context;

namespace SilvRestaurant.Infraestructure.Persistence.Repositories
{
    public class OrderRepository : GenericRepositoryAsync<Order>, IOrderRepository
    {
        public OrderRepository(ApplicationContext dbContext) : base(dbContext)
        {
        }
    }
}
