using AutoMapper;
using SilvRestaurant.Core.Application.Interfaces.Repositories;
using SilvRestaurant.Core.Application.Interfaces.Services;
using SilvRestaurant.Core.Application.ViewModels.CategoryOfDishe;
using System.ComponentModel;

namespace SilvRestaurant.Core.Application.Services
{
    public class CategoryOfDisheService : GenericService<SaveCategoryOfDisheViewModel, CategoryOfDisheViewModel, CategoryAttribute>, ICategoryOfDisheService
    {
        public CategoryOfDisheService(IMapper mapper, IGenericRepositoryAsync<CategoryAttribute> repository) : base(mapper, repository)
        {
        }
    }
}
