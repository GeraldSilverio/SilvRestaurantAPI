using AutoMapper;
using SilvRestaurant.Core.Application.Enums;
using SilvRestaurant.Core.Application.Interfaces.Repositories;
using SilvRestaurant.Core.Application.Interfaces.Services;
using SilvRestaurant.Core.Application.ViewModels.Dishes;
using SilvRestaurant.Core.Application.ViewModels.Order;
using SilvRestaurant.Core.Application.ViewModels.OrderDishe;
using SilvRestaurant.Core.Domain.Entities;

namespace SilvRestaurant.Core.Application.Services
{
    public class OrderService : GenericService<SaveOrderViewModel, OrderViewModel, Order>, IOrderService
    {
        private readonly IOrderDisheService _orderDisheService;
        private readonly IOrderRepository _orderRepository;
        private readonly IDisheService _disheService;
        public OrderService(IMapper mapper, IOrderRepository orderRepository, IOrderDisheService orderDisheService, IDisheService disheService) : base(mapper, orderRepository)
        {
            _orderDisheService = orderDisheService;
            _orderRepository = orderRepository;
            _disheService = disheService;
        }

        public override async Task<SaveOrderViewModel> Add(SaveOrderViewModel model)
        {
            var order = await base.Add(model);

            //Obtener el subtotal
            foreach (var item in model.Dishes)
            {
                var dish = await _disheService.GetById(item);
                order.SubTotal += dish.Price;
            }

            await base.Update(order, order.Id);

            foreach (var dishe in model.Dishes)
            {
                var disheView = new SaveOrderDisheViewModel()
                {
                    IdDishe = dishe,
                    IdOrder = order.Id
                };
                await _orderDisheService.Add(disheView);
            }
            return order;
        }
        public override async Task<List<OrderViewModel>> GetAll()
        {
            var orders = await _orderRepository.GetAllWithIncluideAsync(new List<string> { "OrderDishes.Dishe" });
            return orders.Select(order => new OrderViewModel
            {
                Id = order.Id,
                SubTotal = order.SubTotal,
                IdTable = order.IdTable,
                Status = order.Status,
                Dishe = order.OrderDishes.Select(order => new DisheDataViewModel() { Name = order.Dishe.Name, Price = order.Dishe.Price }).ToList(),
            }).ToList();
        }

        public async Task<OrderViewModel> GetOrderById(int id)
        {
            var orders = await _orderRepository.GetAllWithIncluideAsync(new List<string> { "OrderDishes.Dishe" });
            return orders.Select(order => new OrderViewModel
            {
                Id = order.Id,
                SubTotal = order.SubTotal,
                IdTable = order.IdTable,
                Status = order.Status,
                Dishe = order.OrderDishes.Select(order => new DisheDataViewModel() { Name = order.Dishe.Name, Price = order.Dishe.Price }).ToList(),
            }).FirstOrDefault(x => x.Id == id);
        }

        public async Task<List<OrderViewModel>> GetOrderByIdTable(int idTable)
        {
            var orders = await _orderRepository.GetAllWithIncluideAsync(new List<string> { "OrderDishes.Dishe" });
            return orders.Where(x => x.IdTable == idTable && x.Status == OrderStatus.InProccess.ToString()).Select(order => new OrderViewModel
            {
                Id = order.Id,
                SubTotal = order.SubTotal,
                IdTable = order.IdTable,
                Status = order.Status,
                Dishe = order.OrderDishes.Select(order => new DisheDataViewModel() { Name = order.Dishe.Name, Price = order.Dishe.Price }).ToList(),
            }).ToList();
        }

        public override async Task Update(SaveOrderViewModel model, int id)
        {
            await _orderDisheService.ClearOrderDishe(id);

            foreach (var dishe in model.Dishes)
            {
                var disheIngredien = new SaveOrderDisheViewModel()
                {
                    IdOrder = id,
                    IdDishe = dishe
                };
                await _orderDisheService.Add(disheIngredien);
            }
        }
        public async Task UpdateDishes(List<int> dishes, int id)
        {
            var order = await GetById(id);
            order.Dishes = dishes;
            await Update(order, id);
        }

        public async Task CompletedOrder(int id)
        {
            var order = await base.GetById(id);
            order.Status = OrderStatus.Completed.ToString();
            await base.Update(order, id);
        }
    }
}
