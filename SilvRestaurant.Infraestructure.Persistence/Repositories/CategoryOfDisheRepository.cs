using SilvRestaurant.Core.Application.Interfaces.Repositories;
using SilvRestaurant.Core.Domain.Entities;
using SilvRestaurant.Infraestructure.Persistence.Context;

namespace SilvRestaurant.Infraestructure.Persistence.Repositories
{
    public class CategoryOfDisheRepository : GenericRepositoryAsync<CategoryOfDishe>, ICategoryOfDisheRepository
    {
        public CategoryOfDisheRepository(ApplicationContext dbContext) : base(dbContext)
        {
        }
    }
}
