using SilvRestaurant.Core.Application.ViewModels.Dishes;
using SilvRestaurant.Core.Domain.Entities;

namespace SilvRestaurant.Core.Application.Interfaces.Services
{
    public interface IDisheService:IGenericService<SaveDisheViewModel,DisheViewModel,Dishe>
    {
        Task<DisheViewModel> GetDisheById(int id);
    }
}
