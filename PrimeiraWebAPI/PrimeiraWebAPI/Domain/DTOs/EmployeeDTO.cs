namespace PrimeiraWebAPI.Domain.DTOs
{
    // That's what we want to show to our front-end side
    public class EmployeeDTO
    {
        //public int Id { get; set; }
        public string NameEmployee { get; set; }
        public int Age { get; set; }
        public string? Photo { get; set; }
    }
}