
//using Microsoft.AspNetCore.Identity;

//namespace Bookify11.Wep.Seeds
//{
//    public static class DefaultUsers
//    {
//        public static async Task SeedAdminUserAsync(UserManager<IdentityUser> userManager)
//        {
//            IdentityUser admin = new()
//            {
//                UserName = "admin",
//                Email = "admin@bookify.com",
                
//                EmailConfirmed = true
//            };

//            var user = await userManager.FindByEmailAsync(admin.Email);    //Any

//            if (user is null)
//            {
//                await userManager.CreateAsync(admin, "P@ssword123");
//                await userManager.AddToRoleAsync(admin, "Admin");
//            }
//            //var user = await userManager.FindByEmailAsync(admin.Email); 
//            //var password = "P@ssword123";

//            //await userManager.ChangePasswordAsync(admin, "a1b1c1", password);
//            //if (user == null)
//            //{
//               // await userManager.AddToRoleAsync(admin, AppRoles.Admin);

//                //if (result.Succeeded)
//                //{
//                //    // The admin user was created successfully
                    
//                //}
//                //else
//                //{
//                //    // There was an error creating the admin user
//                //}
//               // await userManager.CreateAsync(admin,"p@ssword123");
               
//            //}
//        }
//    }
//}
