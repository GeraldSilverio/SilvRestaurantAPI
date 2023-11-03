using Microsoft.AspNetCore.Identity;
using SilvRestaurant.Core.Application.Enums;
using SilvRestaurant.Infraestructure.Identity.Entities;

namespace SilvRestaurant.Infraestructure.Identity.Seeds
{
    public static class DefaultAdminUser
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            ApplicationUser defaultUser = new();
            defaultUser.UserName = "adminuser";
            defaultUser.Email = "adminuser@gmail.com";
            defaultUser.FirstName = "Gerald";
            defaultUser.LastName = "Silverio";
            defaultUser.EmailConfirmed = true;
            defaultUser.PhoneNumberConfirmed = true;
            

            if (userManager.Users.All(u => u.Id == defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user is null)
                {
                    await userManager.CreateAsync(defaultUser, "Gerald25@");
                    await userManager.AddToRoleAsync(defaultUser, Rols.Admin.ToString());
                }
            }
        }
    }
}
