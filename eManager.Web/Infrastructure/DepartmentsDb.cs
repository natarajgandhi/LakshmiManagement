using eManager.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace eManager.Web.Infrastructure
{
    public class DepartmentsDb : DbContext,  IDepartmentDataSource
    {
        private DbSet<Employee> _employees;

        public DbSet<Employee> Employees
        {
            get { return _employees; }
            set { _employees = value; }
        }

        private DbSet<Department> _departments;

        public DbSet<Department> Departments
        {
            get { return _departments; }
            set { _departments = value; }
        }




        IQueryable<Employee> IDepartmentDataSource.Employees
        {
            get
            {
                return Employees;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        IQueryable<Department> IDepartmentDataSource.Departments
        {
            get
            {
                return Departments;
            }
            set
            {
                throw new NotImplementedException();
            }
        }


        public void Save()
        {
            SaveChanges();
        }
    }
}