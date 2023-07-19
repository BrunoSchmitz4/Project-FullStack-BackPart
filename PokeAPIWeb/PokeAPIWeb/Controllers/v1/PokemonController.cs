using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PokeAPIWeb.Application.ViewModel;
using PokeAPIWeb.Domain.DTOs;
using PokeAPIWeb.Domain.Models;
using PokeAPIWeb.Domain.Models.PokemonAggregate;

namespace PokeAPIWeb.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/pokemon")]
    [ApiVersion("1.0")]
    public class PokemonController : ControllerBase
    {
        private readonly IPokemonRepository _pokemonRepository;
        private readonly ILogger<PokemonController> _logger;
        private readonly IMapper _mapper;

        public PokemonController(IPokemonRepository pokemonRepository, ILogger<PokemonController> logger, IMapper mapper)
        {
            _pokemonRepository = pokemonRepository ?? throw new ArgumentNullException(nameof(pokemonRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }


        [Authorize]
        [HttpPost]
        [Route("{id}/download")]
        public IActionResult DownloadPhoto(int id)
        {
            var pokemon = _pokemonRepository.Get(id);

            var dataBytes = System.IO.File.ReadAllBytes(pokemon.photo);

            return File(dataBytes, "image/png");
        }

        [Authorize]
        [HttpPost]
        public IActionResult Add([FromForm] PokemonViewModel pokemonView)
        {
            var filePath = Path.Combine("Storage", pokemonView.Photo.FileName);
            using Stream fileStream = new FileStream(filePath, FileMode.Create);

            pokemonView.Photo.CopyTo(fileStream);

            var pokemon = new Pokemon(pokemonView.Name, pokemonView.Type, filePath);
            _pokemonRepository.Add(pokemon);
            return Ok();
        }

        [Authorize]
        [HttpGet]
        public IActionResult Get(int pageNumber, int pageQuantity)
        {
            _logger.Log(LogLevel.Error, "Um erro ocorreu.");

            //throw new Exception("Erro de teste");

            var pokemons = _pokemonRepository.Get(pageNumber, pageQuantity);

            _logger.LogInformation("Um teste bem legal hehe");

            return Ok(pokemons);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Search(int id)
        {
            var pokemons = _pokemonRepository.Get(id);

            var pokemonsDTOS = _mapper.Map<PokemonDTO>(pokemons);

            return Ok(pokemonsDTOS);
        }
    }
}
