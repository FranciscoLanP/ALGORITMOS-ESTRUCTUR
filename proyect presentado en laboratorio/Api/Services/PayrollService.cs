using System.Collections.Generic;
using System.Linq;
using Api.Data;
using Api.Models;

namespace Api.Services
{
    public class PayrollService
    {
        private readonly AppDbContext _context;
        private readonly SinglyLinkedList<Employee> _list = new();

        public PayrollService(AppDbContext context)
        {
            _context = context;
            var empleados = _context.Employees.ToList();
            empleados.ForEach(e => _list.Add(e));
        }

        public void Register(Employee emp)
        {
            var nuevo = new Employee { Name = emp.Name, Salary = emp.Salary };
            _context.Employees.Add(nuevo);
            _context.SaveChanges();
            _list.Add(nuevo);
        }

        public List<Employee> GetAll() => _list.ToList();

        public Employee? GetById(int id) => _list.Find(e => e.Id == id);

        public bool Delete(int id)
        {
            var removed = _list.Remove(e => e.Id == id);
            if (removed)
            {
                var empDb = _context.Employees.Find(id);
                if (empDb != null)
                {
                    _context.Employees.Remove(empDb);
                    _context.SaveChanges();
                }
            }
            return removed;
        }

        public decimal TotalSalaries() => _list.ToList().Sum(e => e.Salary);
    }
}
