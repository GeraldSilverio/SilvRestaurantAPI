using AutoMapper;
using SilvRestaurant.Core.Application.Interfaces.Repositories;
using SilvRestaurant.Core.Application.Interfaces.Services;
using SilvRestaurant.Core.Application.ViewModels.Dishes;
using SilvRestaurant.Core.Domain.Entities;

namespace SilvRestaurant.Core.Application.Services
{
    public class DisheService : GenericService<SaveDisheViewModel, DisheViewModel, Dishe>, IDisheService
    {
        public DisheService(IMapper mapper, IDisheRepository repository) : base(mapper, repository)
        {
        }
    }
}
