using System;
using ProjectYıgıt.WebApp.Entity;

namespace ProjectYıgıt.WebApp.DataAcces.Abstract
{
	public interface IEmployeeRepo
	{
        public Employee CreateEmployee(Employee employee);
        public Employee UpdateEmployee(Employee employee);
        public void DeleteEmployee(int id);
        public List<Employee> GetAllEmployees();
        public Employee GetById(int id);
    }
}

