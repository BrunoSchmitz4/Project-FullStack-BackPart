using Microsoft.EntityFrameworkCore;
using PokeAPIWeb.Domain.Models.PokemonAggregate;

namespace PokeAPIWeb.Infraestrutura
{
    // Herda da classe vinda da Entity Framework
    public class ConnectionContext : DbContext
    {
        public DbSet<Pokemon> Pokemons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(
            "Server=localhost;" +
            "Port=5432;Database=pokemon_sample;" +
            "User id=postgres;" +
            "Password=123;"
            );
    }
}
