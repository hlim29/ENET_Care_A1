using System;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.DataProtection;
using Microsoft.Owin.Security.Google;
using Owin;
using ENET_Care_New.Models;
using System.Web.Security;

namespace ENET_Care_New
{
    public partial class Startup {

        // For more information on configuring authentication, please visit http://go.microsoft.com/fwlink/?LinkId=301883
        public void ConfigureAuth(IAppBuilder app)
        {
            // Configure the db context, user manager and signin manager to use a single instance per request
            app.CreatePerOwinContext(ApplicationDbContext.Create);
            app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);
            app.CreatePerOwinContext<ApplicationSignInManager>(ApplicationSignInManager.Create);

            // Enable the application to use a cookie to store information for the signed in user
            // and to use a cookie to temporarily store information about a user logging in with a third party login provider
            // Configure the sign in cookie
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login"),
                Provider = new CookieAuthenticationProvider
                {
                    OnValidateIdentity = SecurityStampValidator.OnValidateIdentity<ApplicationUserManager, ApplicationUser>(
                        validateInterval: TimeSpan.FromMinutes(30),
                        regenerateIdentity: (manager, user) => user.GenerateUserIdentityAsync(manager))
                }
            });
            // Use a cookie to temporarily store information about a user logging in with a third party login provider
            app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);

            // Enables the application to temporarily store user information when they are verifying the second factor in the two-factor authentication process.
            app.UseTwoFactorSignInCookie(DefaultAuthenticationTypes.TwoFactorCookie, TimeSpan.FromMinutes(5));

            // Enables the application to remember the second login verification factor such as phone or email.
            // Once you check this option, your second step of verification during the login process will be remembered on the device where you logged in from.
            // This is similar to the RememberMe option when you log in.
            app.UseTwoFactorRememberBrowserCookie(DefaultAuthenticationTypes.TwoFactorRememberBrowserCookie);

            // Uncomment the following lines to enable logging in with third party login providers
            //app.UseMicrosoftAccountAuthentication(
            //    clientId: "",
            //    clientSecret: "");

            //app.UseTwitterAuthentication(
            //   consumerKey: "",
            //   consumerSecret: "");

            //app.UseFacebookAuthentication(
            //   appId: "",
            //   appSecret: "");

            //app.UseGoogleAuthentication(new GoogleOAuth2AuthenticationOptions()
            //{
            //    ClientId = "",
            //    ClientSecret = ""
            //});
            var roleManager = new RoleManager<Microsoft.AspNet.Identity.EntityFramework.IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()));


            if (!roleManager.RoleExists("manager"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "manager";
                roleManager.Create(role);
            }

            if (!roleManager.RoleExists("agent"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "agent";
                roleManager.Create(role);
            }

            if (!roleManager.RoleExists("doctor"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "doctor";
                roleManager.Create(role);
            }

            using (var rm = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext())))
            using (var um = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext())))
            {
                var user = um.FindByEmail("agent@enetcare.org");
                um.AddToRole(user.Id, "agent");

                user = um.FindByEmail("manager@enetcare.org");
                um.AddToRole(user.Id, "manager");

                user = um.FindByEmail("doctor@enetcare.org");
                um.AddToRole(user.Id, "doctor");

                 user = um.FindByEmail("agent1@enetcare.org");
                um.AddToRole(user.Id, "agent");

                user = um.FindByEmail("manager1@enetcare.org");
                um.AddToRole(user.Id, "manager");

                user = um.FindByEmail("doctor1@enetcare.org");
                um.AddToRole(user.Id, "doctor");

                user = um.FindByEmail("agent2@enetcare.org");
                um.AddToRole(user.Id, "agent");

                user = um.FindByEmail("manager2@enetcare.org");
                um.AddToRole(user.Id, "manager");

                user = um.FindByEmail("doctor2@enetcare.org");
                um.AddToRole(user.Id, "doctor");

               user = um.FindByEmail("agent3@enetcare.org");
                um.AddToRole(user.Id, "agent");

                user = um.FindByEmail("manager3@enetcare.org");
                um.AddToRole(user.Id, "manager");

                user = um.FindByEmail("doctor3@enetcare.org");
                um.AddToRole(user.Id, "doctor");
            }
        }

    }
}
