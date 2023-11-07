using System;
using ProjectYıgıt.WebApp.Business.Abstract;
using ProjectYıgıt.WebApp.DataAcces.Abstract;
using ProjectYıgıt.WebApp.Entity;

namespace ProjectYıgıt.WebApp.Business.Concrete
{
	public class EmployeeManager : IEmployeeService
	{
        private readonly IEmployeeRepo _repo;


        public EmployeeManager(IEmployeeRepo repo)
        {
            _repo = repo;
        }


        public Employee CreateEmployee(Employee employee)
        {
            return _repo.CreateEmployee(employee);
        }

        public void DeleteEmployee(int id)
        {
            _repo.DeleteEmployee(id);
        }

        public List<Employee> GetAllEmployees()
        {
            return _repo.GetAllEmployees();
        }

        public Employee GetById(int id)
        {
            return _repo.GetById(id);
        }

        public Employee UpdateEmployee(Employee employee)
        {
            return _repo.UpdateEmployee(employee);
        }
    }
}

