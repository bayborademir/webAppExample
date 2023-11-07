using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectYıgıt.WebApp.Business.Abstract;
using ProjectYıgıt.WebApp.DataAcces;
using ProjectYıgıt.WebApp.Entity;

namespace ProjectYıgıt.WebApp.Pages
{
	public class AddEmployeeModel : PageModel
	{
        public Employee NewEmployee { get; set; }


        private readonly IEmployeeService _service;

        public AddEmployeeModel(IEmployeeService service)
        {
            _service = service;
        }

        public void OnPost(Employee emp)
        {
            _service.CreateEmployee(emp);
        }
        
    }
}

