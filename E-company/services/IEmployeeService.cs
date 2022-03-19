using E_company.data;
using E_company.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_company.services
{
    public interface IEmployeeService
    {
        void insert(Employee emp);
        List<Employee> Load(int id);
        void delete(int id);
    }
}
