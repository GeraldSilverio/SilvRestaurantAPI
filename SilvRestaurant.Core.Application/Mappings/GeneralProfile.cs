using AutoMapper;
using SilvRestaurant.Core.Application.ViewModels.CategoryOfDishe;
using SilvRestaurant.Core.Application.ViewModels.DisheIngredient;
using SilvRestaurant.Core.Application.ViewModels.Dishes;
using SilvRestaurant.Core.Application.ViewModels.Ingredient;
using SilvRestaurant.Core.Application.ViewModels.Order;
using SilvRestaurant.Core.Application.ViewModels.OrderDishe;
using SilvRestaurant.Core.Application.ViewModels.Table;
using SilvRestaurant.Core.Domain.Entities;

namespace SilvRestaurant.Core.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {

            #region Ingredient
            CreateMap<Ingredient, IngredientViewModel>()
                .ReverseMap()
                .ForMember(x => x.LastModified, opt => opt.Ignore())
                .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
                .ForMember(x => x.Created, opt => opt.Ignore());

            CreateMap<Ingredient, SaveIngredientViewModel>()
                .ReverseMap()
                .ForMember(x => x.LastModified, opt => opt.Ignore())
                .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
                .ForMember(x => x.Created, opt => opt.Ignore());

            #endregion

            #region Table

            CreateMap<Table, SaveTableViewModel>()
                .ReverseMap()
                .ForMember(x => x.LastModified, opt => opt.Ignore())
                .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
                .ForMember(x => x.Created, opt => opt.Ignore());

            CreateMap<Table, TableViewModel>()
                .ReverseMap()
                .ForMember(x => x.LastModified, opt => opt.Ignore())
                .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
                .ForMember(x => x.Created, opt => opt.Ignore());

            #endregion

            #region Dishes
            CreateMap<CategoryOfDishe, CategoryOfDisheViewModel>()
                .ReverseMap()
                .ForMember(x => x.LastModified, opt => opt.Ignore())
                .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
                .ForMember(x => x.Created, opt => opt.Ignore());

            CreateMap<Dishe, SaveDisheViewModel>()
                .ForMember(x => x.IdIngredients, opt => opt.Ignore())
                .ReverseMap()
                .ForMember(x => x.LastModified, opt => opt.Ignore())
                .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
                .ForMember(x => x.Created, opt => opt.Ignore());

            CreateMap<DisheIngredient, SaveDisheIngredientViewModel>()
                .ReverseMap()
                .ForMember(x => x.LastModified, opt => opt.Ignore())
                .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
                .ForMember(x => x.Created, opt => opt.Ignore());

           

            #endregion

            #region Orders

            CreateMap<Order,SaveOrderViewModel>()
                .ForMember(x=> x.Dishes, opt => opt.Ignore())
                .ReverseMap()
                .ForMember(x => x.LastModified, opt => opt.Ignore())
                .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
                .ForMember(x => x.Created, opt => opt.Ignore());
            
            CreateMap<Order,OrderViewModel>()
                .ForMember(x=> x.Dishe, opt => opt.Ignore())
                .ReverseMap()
                .ForMember(x => x.LastModified, opt => opt.Ignore())
                .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
                .ForMember(x => x.Created, opt => opt.Ignore());

            CreateMap<OrderDishes,SaveOrderDisheViewModel>()
                .ReverseMap()
                .ForMember(x => x.LastModified, opt => opt.Ignore())
                .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
                .ForMember(x => x.Created, opt => opt.Ignore());

            #endregion

        }
    }
}
