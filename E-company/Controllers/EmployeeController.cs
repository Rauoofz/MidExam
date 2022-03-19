using E_company.Models;
using E_company.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace E_company.Controllers
{
    public class EmployeeController : Controller
    {
        IDepartmentService departmentService;
        ICountryService CountryService;
        IEmployeeService employeeService;
        IConfiguration configuration;
        VMCompany vm;
        public EmployeeController(IDepartmentService _departmentService,ICountryService _countryService,IEmployeeService _employeeService,IConfiguration _configuration)
        {
            departmentService = _departmentService;
            CountryService = _countryService;
            employeeService = _employeeService;
            configuration = _configuration;
            vm = new VMCompany();
        }
        public IActionResult Index()
        {
            vm.countries = CountryService.LoadCountry();
            vm.departments = departmentService.LoadDepartment();
            return View("NewEmployee",vm);
        }

        public IActionResult Save(VMCompany vm)
        {
            vm.countries = CountryService.LoadCountry();
            vm.departments = departmentService.LoadDepartment();

            string path = Path.Combine(Directory.GetCurrentDirectory(), configuration["FilePath"], vm.emp.Image.FileName);
            vm.emp.Image.CopyTo(new FileStream(path, FileMode.Create));
            vm.emp.Path = "http://localhost/E-company/img/" + vm.emp.Image.FileName;

            employeeService.insert(vm.emp);


            return View("NewEmployee",vm);
        }
    }
}
