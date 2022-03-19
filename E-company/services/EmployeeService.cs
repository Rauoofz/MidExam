using E_company.data;
using E_company.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_company.services
{
    public class EmployeeService: IEmployeeService
    {
        CompanyContext context;
        public EmployeeService(CompanyContext _context)
        {
            context = _context;
        }
        public void insert(Employee emp)
        {
            context.employees.Add(emp);
            context.SaveChanges();
        }

        public List<Employee> Load(int id)
        {
            List<Employee> employees= context.employees.Where(e => e.ID == id).ToList();
            return employees;

        }

        public void delete(int id)
        {
            Employee emp= context.employees.Find(id);
            context.employees.Remove(emp);
            context.SaveChanges();
        }
    }
}
