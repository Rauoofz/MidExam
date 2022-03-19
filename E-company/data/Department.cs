using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_company.data
{
    public class Department
    {
        public int ID { get; set; }
        public string DepartmentName { get; set; }
        public double MinimumSalary { get; set; }
        public double MaximumSalary { get; set; }
        public List<Employee> employees { get; set; }
    }
}
