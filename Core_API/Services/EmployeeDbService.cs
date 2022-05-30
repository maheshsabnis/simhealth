using Core_API.Models;
using System.Collections.Generic;

namespace Core_API.Services
{
    public class EmployeeDbService : IDbService<Employee, int>
    {
        public Employee Create(Employee entity)
        {
            throw new System.NotImplementedException();
        }

        public Employee Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Employee> Get()
        {
            throw new System.NotImplementedException();
        }

        public Employee Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public Employee Update(int id, Employee entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
