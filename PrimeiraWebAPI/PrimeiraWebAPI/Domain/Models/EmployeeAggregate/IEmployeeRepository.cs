using PrimeiraWebAPI.Domain.DTOs;

namespace PrimeiraWebAPI.Domain.Models.EmployeeAggregate
{
    public interface IEmployeeRepository
    {
        // Methods

        // Used to add the object employee of type employee
        void Add(Employee employee);

        // Used to return a single data
        List<EmployeeDTO> Get(int pageNumber, int pageQuantity);
        Employee? Get(int id);

    }
}
