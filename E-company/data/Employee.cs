using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_company.data
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public string Path { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }
        [ForeignKey("Dept")]
        public int Department_Id { get; set; }
        public Department Dept { get; set; }
        [ForeignKey("cnt")]
        public int Country_ID { get; set; }
        public Country cnt { get; set; }
    }
}
