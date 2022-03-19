using E_company.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_company.Models
{
    public class VMCompany
    {
        public Employee emp { get; set; }
        public List<Country> countries { get; set; }
        public List<Department> departments { get; set; }
    }
}
