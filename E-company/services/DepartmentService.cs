using E_company.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_company.services
{
    public class DepartmentService:IDepartmentService
    {
        CompanyContext context;
        public DepartmentService(CompanyContext _context)
        {
            context = _context;
        }
        public List<Department> LoadDepartment()
        {
            List<Department> departments= context.departments.ToList();
            return departments;
        }
    }
}
