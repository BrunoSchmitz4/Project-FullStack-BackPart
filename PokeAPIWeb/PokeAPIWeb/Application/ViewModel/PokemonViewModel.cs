namespace PokeAPIWeb.Application.ViewModel
{
    public class PokemonViewModel
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public IFormFile Photo { get; set; }
    }
}
