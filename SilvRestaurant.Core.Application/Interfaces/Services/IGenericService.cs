namespace SilvRestaurant.Core.Application.Interfaces.Services
{
    public interface IGenericService<SaveViewModel, ViewModel, Model>
        where SaveViewModel : class
        where ViewModel : class
        where Model : class
    {
        Task Update(SaveViewModel model, int id);
        Task<SaveViewModel> Add(SaveViewModel model);
        Task Delete(int id);
        Task<SaveViewModel> GetById(int id);
        Task<List<ViewModel>> GetAll();
    }
}
