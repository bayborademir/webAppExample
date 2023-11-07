using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectYıgıt.WebApp.Business.Abstract;
using ProjectYıgıt.WebApp.DataAcces;
using ProjectYıgıt.WebApp.Entity;

namespace ProjectYıgıt.WebApp.Pages;

public class IndexModel : PageModel
{
    private readonly IEmployeeService _service;

    public IEnumerable<Employee> Employees { get; set; }

    public IndexModel(IEmployeeService service)
    {
        _service = service;
    }

    public void OnGet()
    {
        Employees = _service.GetAllEmployees();
    }

}

