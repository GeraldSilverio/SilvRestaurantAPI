using SilvRestaurant.Core.Application.Interfaces.Repositories;
using SilvRestaurant.Core.Domain.Entities;
using SilvRestaurant.Infraestructure.Persistence.Context;

namespace SilvRestaurant.Infraestructure.Persistence.Repositories
{
    public class TableRepository : GenericRepositoryAsync<Table>, ITableRepository
    {
        public TableRepository(ApplicationContext dbContext) : base(dbContext)
        {
        }
    }
}
