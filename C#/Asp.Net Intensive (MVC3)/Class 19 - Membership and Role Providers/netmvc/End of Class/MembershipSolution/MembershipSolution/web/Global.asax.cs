using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;

namespace web
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        private void AddDefaultUsersAndRoles()
        {
            var adminUser = System.Configuration.ConfigurationManager.AppSettings["AdminUser"];
            var adminRole = System.Configuration.ConfigurationManager.AppSettings["AdminRole"];
            var roles = System.Configuration.ConfigurationManager.AppSettings["OtherRoles"];
            if (adminRole != null && !Roles.RoleExists(adminRole))
                Roles.CreateRole(adminRole);

            if (adminUser != null && Membership.GetUser(adminUser) == null)
            {
                Membership.CreateUser(adminUser, "password");

            }

            if (adminRole != null && adminUser != null)
            {
                if (!Roles.IsUserInRole(adminUser, adminRole))
                    Roles.AddUserToRole(adminUser, adminRole);
            }

            if (roles != null)
            {
                foreach (var role in roles.Split(','))
                    if (!Roles.RoleExists(role))
                        Roles.CreateRole(role);
            }
        }
        protected void Application_Start()
        {
            AddDefaultUsersAndRoles();
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }
}