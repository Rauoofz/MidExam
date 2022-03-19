using E_company.data;
using E_company.Models;
using E_company.services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_company.Controllers
{
    public class DepartmentController : Controller
    {
        IDepartmentService DepartmentService;
        IEmployeeService employeeService;
        VMDEPT vm;
        public DepartmentController(IDepartmentService _departmentService, IEmployeeService _employeeService)
        {
            DepartmentService = _departmentService;
            employeeService = _employeeService;
            vm = new VMDEPT();
        }
        public IActionResult Index()
        {
            vm.departments  = DepartmentService.LoadDepartment();
            List<Employee> employees = new List<Employee>();
            vm.employees = employees;
            return View("DepartmentList",vm);
        }

        public IActionResult Details(int id)
        {
            vm.departments = DepartmentService.LoadDepartment();
            List<Employee> employees = new List<Employee>();
            vm.employees = employeeService.Load(id);
            
            return View("DepartmentList", vm);
        }

        public IActionResult delete(int id)
        {
            vm.departments = DepartmentService.LoadDepartment();
            List<Employee> employees = new List<Employee>();
            vm.employees = employees;
            employeeService.delete(id);

            return View("DepartmentList", vm);
        }

        public IActionResult Employee()
        {
            return RedirectToAction("Index", "Employee");
        }


    }
}
