using PokeAPIWeb.Domain.DTOs;
using PokeAPIWeb.Domain.Models.PokemonAggregate;

namespace PokeAPIWeb.Infraestrutura.Repositories
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();
        public void Add(Pokemon pokemon)
        {
            _context.Pokemons.Add(pokemon);
            _context.SaveChanges();
        }

        public List<PokemonDTO> Get(int pageNumber, int pageQuantity)
        {
            return _context.Pokemons.Skip(pageNumber * pageQuantity).Take(pageQuantity).Select(b => new PokemonDTO()
            {
                NamePokemon = b.name,
                Type = b.type,
                Photo = b.photo,
            }).ToList();
        }

        public Pokemon? Get(int id)
        {
            return _context.Pokemons.Find(id);
        }
    }
}
