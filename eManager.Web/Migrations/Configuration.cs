namespace eManager.Web.Migrations
{
    using eManager.Domain;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Web.Security;

    internal sealed class Configuration : DbMigrationsConfiguration<eManager.Web.Infrastructure.DepartmentsDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(eManager.Web.Infrastructure.DepartmentsDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Departments.AddOrUpdate(
                p => p.Name,
                new Department { Name = "Human Resources" },
                new Department { Name = "Finance" },
                new Department { Name = "IT" },
                new Department { Name = "Accounts" },
                new Department { Name = "Engineering" }
                );
            //if (Roles.RoleExists("Admin"))
            //{
            //    Roles.CreateRole("Admin");
            //}
            //if (Membership.GetUser("Nat") == null)
            //{
            //    Membership.CreateUser("Nat", "FluffBunny");
            //    Roles.AddUserToRole("Nat", "Admin");
            //}
        }
    }
}
