using SilvRestaurant.Core.Application.Interfaces.Repositories;
using SilvRestaurant.Core.Domain.Entities;
using SilvRestaurant.Infraestructure.Persistence.Context;

namespace SilvRestaurant.Infraestructure.Persistence.Repositories
{
    public class DisheRepository : GenericRepositoryAsync<Dishe>, IDisheRepository
    {
        public DisheRepository(ApplicationContext dbContext) : base(dbContext)
        {
        }
    }
}
