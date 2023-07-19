using AutoMapper;
using PokeAPIWeb.Domain.DTOs;
using PokeAPIWeb.Domain.Models.PokemonAggregate;
using System.IO.Compression;

namespace PokeAPIWeb.Application.Mapping
{
    public class DomainToDTOMapping : Profile
    {
        public DomainToDTOMapping()
        {
            CreateMap<Pokemon, PokemonDTO>()
                .ForMember(dest => dest.NamePokemon, m => m.MapFrom(orig => orig.name));
        }
    }
}
