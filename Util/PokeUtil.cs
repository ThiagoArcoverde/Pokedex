namespace Pokedex.Util
{
    public static class PokeUtil
    {
        public const string Pokeball = "pokeball.png";
        public const string Greatball = "greatball.png";
        public const string Ultraball = "ultraball.png";
        public const string Masterball = "masterball.png";

        public static string GetRandomBall()
        {
            string[] pokeballArray = new string[] { Pokeball, Greatball, Ultraball, Masterball };
            Random rand = new Random();
            return pokeballArray[rand.Next(pokeballArray.Length)];
        }

        public static double GetPokemonHeightInMeters(int height)
        {
            return Convert.ToDouble(height) / 10;
        }

        public static double GetPokemonWeightInKilograms(int weight)
        {
            return Convert.ToDouble(weight) / 10;
        }
    }
}
