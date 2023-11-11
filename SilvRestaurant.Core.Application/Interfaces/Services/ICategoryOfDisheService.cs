using SilvRestaurant.Core.Application.ViewModels.CategoryOfDishe;
using SilvRestaurant.Core.Domain.Entities;

namespace SilvRestaurant.Core.Application.Interfaces.Services
{
    public interface ICategoryOfDisheService:IGenericService<SaveCategoryOfDisheViewModel,CategoryOfDisheViewModel,CategoryOfDishe>
    {
    }
}
