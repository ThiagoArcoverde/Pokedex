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

        public async Task<Pokemon?> GetPokemon(string id)
        {
            var response = await Client.GetAsync($"https://pokeapi.co/api/v2/pokemon/{id}");
            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Pokemon>(content);
        }

        public async Task<List<Pokemon>> GetKantoPokemon()
        {
            var pokemonList = new List<Pokemon>();
            for (int i = 1; i <= 151; i++)
            {
                Pokemon? pokemon = await GetPokemon(i.ToString());
                if (pokemon != null)
                {
                    pokemonList.Add(pokemon);
                }
            }
            return pokemonList;
        }

        public async Task<List<Pokemon>> GetJohtoPokemon()
        {
            var pokemonList = new List<Pokemon>();
            for (int i = 152; i <= 251; i++)
            {
                Pokemon? pokemon = await GetPokemon(i.ToString());
                if (pokemon != null)
                {
                    pokemonList.Add(pokemon);
                }
            }
            return pokemonList;
        }

        public async Task<List<Pokemon>> GetHoennPokemon()
        {
            var pokemonList = new List<Pokemon>();
            for (int i = 252; i <= 386; i++)
            {
                Pokemon? pokemon = await GetPokemon(i.ToString());
                if (pokemon != null)
                {
                    pokemonList.Add(pokemon);
                }
            }
            return pokemonList;
        }

        public async Task<List<Pokemon>> GetSinnohPokemon()
        {
            var pokemonList = new List<Pokemon>();
            for (int i = 387; i <= 493; i++)
            {
                Pokemon? pokemon = await GetPokemon(i.ToString());
                if (pokemon != null)
                {
                    pokemonList.Add(pokemon);
                }
            }
            return pokemonList;
        }

        public async Task<List<Pokemon>> GetUnovaPokemon()
        {
            var pokemonList = new List<Pokemon>();
            for (int i = 494; i <= 694; i++)
            {
                Pokemon? pokemon = await GetPokemon(i.ToString());
                if (pokemon != null)
                {
                    pokemonList.Add(pokemon);
                }
            }
            return pokemonList;
        }

        public async Task<List<Pokemon>> GetKalosPokemon()
        {
            var pokemonList = new List<Pokemon>();
            for (int i = 650; i <= 721; i++)
            {
                Pokemon? pokemon = await GetPokemon(i.ToString());
                if (pokemon != null)
                {
                    pokemonList.Add(pokemon);
                }
            }
            return pokemonList;
        }

        public async Task<List<Pokemon>> GetAlolaPokemon()
        {
            var pokemonList = new List<Pokemon>();
            for (int i = 722; i <= 809; i++)
            {
                Pokemon? pokemon = await GetPokemon(i.ToString());
                if (pokemon != null)
                {
                    pokemonList.Add(pokemon);
                }
            }
            return pokemonList;
        }

        public async Task<List<Pokemon>> GetGalarPokemon()
        {
            var pokemonList = new List<Pokemon>();
            for (int i = 810; i <= 905; i++)
            {
                Pokemon? pokemon = await GetPokemon(i.ToString());
                if (pokemon != null)
                {
                    pokemonList.Add(pokemon);
                }
            }
            return pokemonList;
        }

        public async Task<List<Pokemon>> GetPaldeaPokemon()
        {
            var pokemonList = new List<Pokemon>();
            for (int i = 906; i <= 1017; i++)
            {
                Pokemon? pokemon = await GetPokemon(i.ToString());
                if (pokemon != null)
                {
                    pokemonList.Add(pokemon);
                }
            }
            return pokemonList;
        }
    }
}