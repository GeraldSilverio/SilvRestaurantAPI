using AutoMapper;
using SilvRestaurant.Core.Application.Interfaces.Repositories;
using SilvRestaurant.Core.Application.Interfaces.Services;
using SilvRestaurant.Core.Application.ViewModels.Table;
using SilvRestaurant.Core.Domain.Entities;

namespace SilvRestaurant.Core.Application.Services
{
    public class TableService : GenericService<SaveTableViewModel, TableViewModel, Table>, ITableService
    {
        public TableService(IMapper mapper, ITableRepository tableRepository) : base(mapper, tableRepository)
        {
        }
    }
}
