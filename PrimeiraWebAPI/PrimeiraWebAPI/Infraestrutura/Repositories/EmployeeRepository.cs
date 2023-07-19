using PrimeiraWebAPI.Domain.DTOs;
using PrimeiraWebAPI.Domain.Models.EmployeeAggregate;

namespace PrimeiraWebAPI.Infraestrutura.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();

        public void Add(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public List<EmployeeDTO> Get(int pageNumber, int pageQuantity)
        {
            return _context.Employees.Skip(pageNumber * pageQuantity)
                .Take(pageQuantity)
                .Select(b =>
                new EmployeeDTO()
                {
                    Age = b.age,
                    NameEmployee = b.name,
                    Photo = b.photo
                }).ToList();
        }

        public Employee? Get(int id)
        {
            return _context.Employees.Find(id);
        }
    }
}