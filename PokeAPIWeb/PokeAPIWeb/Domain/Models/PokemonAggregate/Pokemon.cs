using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PokeAPIWeb.Domain.Models.PokemonAggregate
{
    [Table("pokemon")]
    public class Pokemon
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string? photo { get; set; }


        public Pokemon() { }
        public Pokemon(string name, string type, string photo)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.type = type;
            this.photo = photo;
        }
    }
}
