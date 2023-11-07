using System;
using ProjectYıgıt.WebApp.DataAcces.Abstract;
using ProjectYıgıt.WebApp.Entity;

namespace ProjectYıgıt.WebApp.DataAcces.Concrete
{
	public class EmployeeRepo : IEmployeeRepo
	{
        private readonly ProjectYıgıtDbContext _db;

        public EmployeeRepo(ProjectYıgıtDbContext db)
        {
            _db = db;
        }

        public Employee CreateEmployee(Employee employee)
        {
            _db.Employees.Add(employee);
            _db.SaveChanges();
            return employee;
        }

        public void DeleteEmployee(int id)
        {
            var deleted = _db.Employees.Find(id);
            _db.Employees.Remove(deleted);
            _db.SaveChanges();
        }

        public List<Employee> GetAllEmployees()
        {
            return _db.Employees.ToList();
        }

        public Employee GetById(int id)
        {
            return _db.Employees.Find(id);
        }

        public Employee UpdateEmployee(Employee employee)
        {
            _db.Employees.Update(employee);
            _db.SaveChanges();
            return null;
        }
    }
}

