using AutoMapper;
using SilvRestaurant.Core.Application.Enums;
using SilvRestaurant.Core.Application.Interfaces.Repositories;
using SilvRestaurant.Core.Application.Interfaces.Services;
using SilvRestaurant.Core.Application.ViewModels.Table;
using SilvRestaurant.Core.Domain.Entities;

namespace SilvRestaurant.Core.Application.Services
{
    public class TableService : GenericService<SaveTableViewModel, TableViewModel, Table>, ITableService
    {
        private readonly ITableRepository _tableRepository;

        public TableService(IMapper mapper, ITableRepository tableRepository) : base(mapper, tableRepository)
        {
            _tableRepository = tableRepository;
        }

        public async Task ChangeStatus(int idTable, int StatusId)
        {
            var table = await _tableRepository.GetByIdAsync(idTable);
            switch (StatusId)
            {
                case 1: table.StatusOfTable = StatusOfTable.Avalible.ToString(); break;
                case 2: table.StatusOfTable = StatusOfTable.InProgress.ToString(); break;
                case 3: table.StatusOfTable = StatusOfTable.Attended.ToString(); break;

            }
            await _tableRepository.UpdateAsync(table, idTable);
        }

        public override async Task Update(SaveTableViewModel model, int id)
        {
            var table = await _tableRepository.GetByIdAsync(id);
            model.StatusOfTable = table.StatusOfTable;
            await base.Update(model, id);
        }

    }
}
