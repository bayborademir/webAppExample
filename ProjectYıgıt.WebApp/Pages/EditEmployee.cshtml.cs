using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjectYıgıt.WebApp.Business.Abstract;
using ProjectYıgıt.WebApp.DataAcces;
using ProjectYıgıt.WebApp.Entity;

namespace ProjectYıgıt.WebApp.Pages
{
	public class EditEmployeeModel : PageModel
	{
		public Employee  EditEmployee { get; set; }

		private readonly IEmployeeService _service;

        public EditEmployeeModel(IEmployeeService service)
        {
            _service = service;
        }

        public IActionResult OnGet(int id)       
        {
           EditEmployee = _service.GetById(id);
            return Page();
        }

        public IActionResult OnPost(Employee emp)
        {
            _service.UpdateEmployee(emp);
            return RedirectToPage("Index");
        }

        
    }
}

