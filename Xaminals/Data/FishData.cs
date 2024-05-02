using Xaminals.Models;

namespace Xaminals.Data
{
    public static class FishData
    {
        public static IList<Animal> Fish { get; private set; }

        static FishData()
        {
            Fish = new List<Animal>();

            Fish.Add(new Animal
            {
                Name = "Galjoen",
                Location = "Africa",
                Details = "The galjoen, black bream, or blackfish (Dichistius capensis) is a species of marine fish found only along the coast of South Africa. Galjoen is the national fish of South Africa.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/31/Dichistius_capensis_Histoire_naturelle_des_poissons_%2810438601306%29.jpg/1280px-Dichistius_capensis_Histoire_naturelle_des_poissons_%2810438601306%29.jpg"
            });

            Fish.Add(new Animal
            {
                Name = "Gymnarchus",
                Location = "Africa",
                Details = "Gymnarchus niloticus – commonly known as the aba, aba aba, frankfish, freshwater rat-tail, poisson-cheval, or African knifefish – is an electric fish, and the only species in the genus Gymnarchus and the family Gymnarchidae within the order Osteoglossiformes. It is found in swamps, lakes and rivers in the Nile, Turkana, Chad, Niger, Volta, Senegal, and Gambia basins.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/8/8f/Gymnarchus_niloticus005.JPG"
            });

        }
    }
}


