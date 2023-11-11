using AutoMapper;
using SilvRestaurant.Core.Application.Interfaces.Repositories;
using SilvRestaurant.Core.Application.Interfaces.Services;

namespace SilvRestaurant.Core.Application.Services
{
    public class GenericService<SaveViewModel, ViewModel, Model> : IGenericService<SaveViewModel, ViewModel, Model>
        where SaveViewModel : class
        where ViewModel : class
        where Model : class
    {
        private readonly IGenericRepositoryAsync<Model> _repository;
        private readonly IMapper _mapper;

        public GenericService(IMapper mapper, IGenericRepositoryAsync<Model> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public virtual async Task<SaveViewModel> Add(SaveViewModel model)
        {
            var entity = _mapper.Map<Model>(model);
            entity = await _repository.AddAsync(entity);
            SaveViewModel entityVm = _mapper.Map<SaveViewModel>(entity);
            return entityVm;

        }

        public virtual async Task Delete(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            await _repository.DeleteAsync(entity);
        }

        public async Task<List<ViewModel>> GetAll()
        {
            var entities = await _repository.GetAllAsync();
            return _mapper.Map<List<ViewModel>>(entities);

        }

        public virtual async Task<SaveViewModel> GetById(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return _mapper.Map<SaveViewModel>(entity);
        }

        public virtual async Task Update(SaveViewModel model, int id)
        {
            var entity = _mapper.Map<Model>(model);
            await _repository.UpdateAsync(entity, id);
        }
    }
}
