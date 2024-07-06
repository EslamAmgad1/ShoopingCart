using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using myshop.Entities.Models;
using myshop.Utilities;
namespace myshop.DataAccess.DbInitializer

{
    public class DbInitializer : IDbInitializer
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _context;

        public DbInitializer(UserManager<IdentityUser> userManager,RoleManager<IdentityRole> roleManager , ApplicationDbContext context)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;
        }
        public void Initialize()
        {
            try
            {
                if (_context.Database.GetPendingMigrations().Count() > 0) 
                {
                    _context.Database.Migrate();
                }
            }
            catch (Exception) 
            {
                throw;
            }

            if (!_roleManager.RoleExistsAsync(SD.AdminRole).GetAwaiter().GetResult())
            {
                _roleManager.CreateAsync(new IdentityRole(SD.AdminRole)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(SD.EditorRole)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(SD.CustomerRole)).GetAwaiter().GetResult();


                _userManager.CreateAsync(new ApplicationUser()
                {
                    UserName = "Admin@myshop.com",
                    Email = "Admin@myshop.com",
                    Name = "DefaultAdmin",
                    PhoneNumber = "1234567890",
                    Address = "Alex",
                    City = "Alex"

                }, "Password@2000").GetAwaiter().GetResult();

                var user = _context.ApplicationUsers.FirstOrDefault(u => u.Email == "Admin@myshop.com");
                _userManager.AddToRoleAsync(user, SD.AdminRole).GetAwaiter().GetResult();

            }

        }
    }
}
