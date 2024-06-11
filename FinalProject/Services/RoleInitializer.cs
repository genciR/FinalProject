using Microsoft.AspNetCore.Identity;
using FinalProject.Models;
using System.Threading.Tasks;

namespace FinalProject.Services
{
    public static class RoleInitializer
    {
        public static async Task InitializeAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            string adminEmail = "admin@phonestore.com";
            string customerEmail = "customer@phonestore.com";
            string password = "Password123!";

            if (await roleManager.FindByNameAsync("Administrator") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("Administrator"));
            }

            if (await roleManager.FindByNameAsync("Customer") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("Customer"));
            }

            if (await userManager.FindByNameAsync(adminEmail) == null)
            {
                ApplicationUser admin = new ApplicationUser { Email = adminEmail, UserName = adminEmail };
                IdentityResult result = await userManager.CreateAsync(admin, password);

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin, "Administrator");
                }
            }

            if (await userManager.FindByNameAsync(customerEmail) == null)
            {
                ApplicationUser customer = new ApplicationUser { Email = customerEmail, UserName = customerEmail };
                IdentityResult result = await userManager.CreateAsync(customer, password);

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(customer, "Customer");
                }
            }
        }
    }
}
