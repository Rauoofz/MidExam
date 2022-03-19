using E_company.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_company.Models
{
    public class VMDEPT
    {
        public List<Department> departments { get; set; }
        public List<Employee> employees { get; set; }
    }
}
