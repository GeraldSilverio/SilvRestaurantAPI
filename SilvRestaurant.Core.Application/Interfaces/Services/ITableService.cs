using SilvRestaurant.Core.Application.ViewModels.Table;
using SilvRestaurant.Core.Domain.Entities;

namespace SilvRestaurant.Core.Application.Interfaces.Services
{
    public interface ITableService:IGenericService<SaveTableViewModel,TableViewModel,Table>
    {
    }
}
