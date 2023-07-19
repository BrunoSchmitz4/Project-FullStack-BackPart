using PokeAPIWeb.Domain.DTOs;

namespace PokeAPIWeb.Domain.Models.PokemonAggregate
{
    public interface IPokemonRepository
    {
        // Add a pokemon
        void Add(Pokemon pokemon);

        // Return a pokemon
        List<PokemonDTO> Get(int pageNumber, int pageQuantity);
        Pokemon Get(int id);
    }
}
