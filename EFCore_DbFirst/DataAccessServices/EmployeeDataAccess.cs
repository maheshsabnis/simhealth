using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCore_DbFirst.Models;
namespace EFCore_DbFirst.DataAccessServices
{
    public class EmployeeDataAccess : IDataAccess<Employee, int>
    {
        public Employee Create(Employee entity)
        {
            throw new NotImplementedException();
        }

        public Employee Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> Get()
        {
            throw new NotImplementedException();
        }

        public Employee Get(int id)
        {
            throw new NotImplementedException();
        }

        public Employee Update(int id, Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
