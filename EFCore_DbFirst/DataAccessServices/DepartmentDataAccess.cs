using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCore_DbFirst.Models;
namespace EFCore_DbFirst.DataAccessServices
{
    public class DepartmentDataAccess : IDataAccess<Department, int>
    {
        public Department Create(Department entity)
        {
            throw new NotImplementedException();
        }

        public Department Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Department> Get()
        {
            throw new NotImplementedException();
        }

        public Department Get(int id)
        {
            throw new NotImplementedException();
        }

        public Department Update(int id, Department entity)
        {
            throw new NotImplementedException();
        }
    }
}
