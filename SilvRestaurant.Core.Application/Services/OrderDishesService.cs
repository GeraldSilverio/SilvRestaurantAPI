using AutoMapper;
using SilvRestaurant.Core.Application.Interfaces.Repositories;
using SilvRestaurant.Core.Application.Interfaces.Services;
using SilvRestaurant.Core.Application.ViewModels.OrderDishe;
using SilvRestaurant.Core.Domain.Entities;

namespace SilvRestaurant.Core.Application.Services
{
    public class OrderDishesService : GenericService<SaveOrderDisheViewModel, OrderDisheViewModel, OrderDishes>, IOrderDisheService
    {
        private readonly IOrderDisheRepository _orderDisheRepository;
        public OrderDishesService(IMapper mapper, IOrderDisheRepository orderDisheRepository) : base(mapper, orderDisheRepository)
        {
            _orderDisheRepository = orderDisheRepository;
        }

        public async Task ClearOrderDishe(int idOrder)
        {
           await _orderDisheRepository.ClearOrderDishe(idOrder);
        }

    }
}
