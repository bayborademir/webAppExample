using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectYıgıt.WebApp.Business.Abstract;
using ProjectYıgıt.WebApp.Entity;

namespace ProjectYıgıt.WebApp.API
{

    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _service;


        public EmployeeController(IEmployeeService service)
        {
            _service = service;
        }

        [HttpPost]
        public Employee CreateEmployee(Employee employee)
        {
            return _service.CreateEmployee(employee);
        }

        [HttpGet]
        public List<Employee> GetAllEmployees()
        {
            return _service.GetAllEmployees();
        }

        [HttpGet("id")]
        public Employee FindById(int id)
        {
            return _service.GetById(id);
        }

        [HttpDelete("int")]
        [Route("delete/{id}")]
        public void DeleteEmployee(int id)
        {
            _service.DeleteEmployee(id);
        }
      
    }

}
