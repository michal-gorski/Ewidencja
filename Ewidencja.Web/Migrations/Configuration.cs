using System.Web.Security;
using WebMatrix.WebData;

namespace Ewidencja.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Ewidencja.Models.UsersContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Ewidencja.Models.UsersContext context)
        {
            WebSecurity.InitializeDatabaseConnection(
                 "DefaultConnection",
                 "UserProfile",
                 "UserId",
                 "UserName", autoCreateTables: true);

            if (!Roles.RoleExists("Administrator"))
                Roles.CreateRole("Administrator");

            if (!Roles.RoleExists("Doctor"))
                Roles.CreateRole("Doctor");

            if (!Roles.RoleExists("Assistant"))
                Roles.CreateRole("Assistant");



            if (!WebSecurity.UserExists("admin"))
                WebSecurity.CreateUserAndAccount(
                    "admin",
                    "password",
                    new { Mobile = "+48 604 103 906" });

            if (!Roles.GetRolesForUser("admin").Contains("Administrator"))
                Roles.AddUsersToRoles(new[] { "admin" }, new[] { "Administrator" });

            if (!Roles.GetRolesForUser("admin").Contains("Doctor"))
                Roles.AddUsersToRoles(new[] { "admin" }, new[] { "Doctor" });


            if (!WebSecurity.UserExists("assistant"))
                WebSecurity.CreateUserAndAccount(
                    "assistant",
                    "password",
                    new { Mobile = "+48 604 103 906" });

            if (!Roles.GetRolesForUser("assistant").Contains("Assistant"))
                Roles.AddUsersToRoles(new[] { "assistant" }, new[] { "Assistant" });


        }
    }
}
