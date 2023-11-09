namespace Pokedex.Models
{
    public class Region
    {
        public List<Pokemon> Kanto { get; set; } = new List<Pokemon>();
        public List<Pokemon> Johto { get; set; } = new List<Pokemon>();
        public List<Pokemon> Hoenn { get; set; } = new List<Pokemon>();
        public List<Pokemon> Sinnoh { get; set; } = new List<Pokemon>();
        public List<Pokemon> Unova { get; set; } = new List<Pokemon>();
        public List<Pokemon> Kalos { get; set; } = new List<Pokemon>();
        public List<Pokemon> Alola { get; set; } = new List<Pokemon>();
        public List<Pokemon> Galar { get; set; } = new List<Pokemon>();
        public List<Pokemon> Paldea { get; set; } = new List<Pokemon>();

    }
}
