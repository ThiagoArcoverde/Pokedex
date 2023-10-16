namespace Pokedex.Util
{
    public static class PokeColor
    {
        public static string GetTypeColor(string type)
        {
            return type switch
            {
                "bug" => "#A6B91A",
                "dark" => "#705746",
                "dragon" => "#6F35FC",
                "electric" => "#F7D02C",
                "fairy" => "#D685AD",
                "fighting" => "#C22E28",
                "fire" => "#EE8130",
                "flying" => "#A98FF3",
                "grass" => "#7AC74C",
                "ground" => "#E2BF65",
                "ghost" => "#735797",
                "ice" => "#96D9D6",
                "normal" => "#A8A77A",
                "poison" => "#A33EA1",
                "psychic" => "#F95587",
                "rock" => "#B6A136",
                "water" => "#6390F0",
                "steel" => "#B7B7CE",
                _ => "#000000",
            };
        }

        public static string GetStatColor(string stat)
        {
            return stat switch
            {
                "hp" => "#FE0000",
                "attack" => "#EE7F30",
                "defense" => "#F7D02C",
                "special-attack" => "#F85687",
                "special-defense" => "#77c755",
                "speed" => "#678FEE",
                _ => "#0190FF"
            };
        }
    }
}
