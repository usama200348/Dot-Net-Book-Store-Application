using Microsoft.AspNetCore.Identity;
using Book_Store.Constatns;

namespace Book_Store.Data
{
    public class DbSender
    {
        public static async Task SendDefaultData(IServiceProvider service)
        {
            var userManager = service.GetService<UserManager<IdentityUser>>();
            var RoleManager = service.GetService<RoleManager<IdentityRole>>();
            //Adding Default Roles In Database
            await RoleManager.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
            await RoleManager.CreateAsync(new IdentityRole(Roles.User.ToString()));
            //Creatig Admin
            var admin = new IdentityUser
            {
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                EmailConfirmed = true,
            };
            var userInDb = await userManager.FindByEmailAsync(admin.Email);
            //Condition If Amin Email Dosenot Exists

            if (userInDb == null)
            {
                await userManager.CreateAsync(admin, "Admin@123");
                await userManager.AddToRoleAsync(admin, Roles.Admin.ToString());
            } 
        }
    }
}
