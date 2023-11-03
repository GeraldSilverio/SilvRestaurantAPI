using Microsoft.AspNetCore.Identity;
using SilvRestaurant.Core.Application.Enums;
using SilvRestaurant.Infraestructure.Identity.Entities;

namespace SilvRestaurant.Infraestructure.Identity.Seeds
{
    public static class DefaultRols
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole(Rols.Admin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Rols.Mesero.ToString()));
        }
    }
}
