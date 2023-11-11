using AutoMapper;
using SilvRestaurant.Core.Application.Interfaces.Repositories;
using SilvRestaurant.Core.Application.Interfaces.Services;
using SilvRestaurant.Core.Application.ViewModels.CategoryOfDishe;
using SilvRestaurant.Core.Domain.Entities;

namespace SilvRestaurant.Core.Application.Services
{
    public class CategoryOfDisheService : GenericService<SaveCategoryOfDisheViewModel, CategoryOfDisheViewModel, CategoryOfDishe>, ICategoryOfDisheService
    {
        public CategoryOfDisheService(IMapper mapper, ICategoryOfDisheRepository repository) : base(mapper, repository)
        {
        }
    }
}
