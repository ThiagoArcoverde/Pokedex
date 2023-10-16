using Pokedex.Models;
using System.Text.Json;

namespace Pokedex.Util
{
    public class PokeClient
    {
        public HttpClient Client { get; }
        public PokeClient(HttpClient client)
        {
            Client = client;
        }

        public async Task<Pokemon> GetPokemon(string id)
        {
            var response = await Client.GetAsync($"https://pokeapi.co/api/v2/pokemon/{id}");
            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Pokemon>(content);
        }
    }
}