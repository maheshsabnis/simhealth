using Core_API.Models;
using System.Collections.Generic;
using System.Linq;

namespace Core_API.Services
{
    public class DepartmentDbService : IDbService<Department, int>
    {
        private readonly CompanyContext context;
        /// <summary>
        /// Inject the CompanyContext to the DepartmentDbService class
        /// </summary>
        public DepartmentDbService(CompanyContext ctx)
        {
            context = ctx;
        }


        public Department Create(Department entity)
        {
            context.Departments.Add(entity);
            context.SaveChanges();
            return entity;
        }

        public Department Delete(int id)
        {
            var deptToDelete = context.Departments.Find(id);
            if(deptToDelete == null) return null;

            context.Departments.Remove(deptToDelete);
            context.SaveChanges();
            return deptToDelete;
        }

        public IEnumerable<Department> Get()
        {
            return context.Departments.ToList();
        }

        public Department Get(int id)
        {
            var deptToFind = context.Departments.Find(id);
            return deptToFind;
        }

        public Department Update(int id, Department entity)
        {
            var deptToUpdate = context.Departments.Find(id);
            if(deptToUpdate == null) return null;

            deptToUpdate.DeptName = entity.DeptName;
            deptToUpdate.Location = entity.Location;
            deptToUpdate.Capacity = entity.Capacity;
            context.SaveChanges();
            return deptToUpdate;
        }
    }
}
