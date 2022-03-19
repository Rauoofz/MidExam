using E_company.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_company.services
{
    public interface IDepartmentService
    {
        List<Department> LoadDepartment();
    }
}
