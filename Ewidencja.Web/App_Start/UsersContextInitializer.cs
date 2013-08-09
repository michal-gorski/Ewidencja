using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Web.Security;
using Ewidencja.DTOs;
using System.Linq;
using Ewidencja.Models;
using WebMatrix.WebData;


namespace Ewidencja
{
    internal class UsersContextInitializer : DropCreateDatabaseIfModelChanges<UsersContext>
    {
        protected override void Seed(UsersContext context)
        {
            base.Seed(context);

            WebSecurity.InitializeDatabaseConnection(
               "Ewidencja.AspNet.UsersContext",
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
