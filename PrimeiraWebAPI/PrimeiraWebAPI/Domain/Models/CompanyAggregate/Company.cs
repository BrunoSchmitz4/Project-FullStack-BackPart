using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeiraWebAPI.Domain.Models.CompanyAggregate
{
    [Table("company")]
    public class Company
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
