using Xaminals.Models;

namespace Xaminals.Data
{
    public static class SnakeData
    {
        public static IList<Animal> Snakes { get; private set; }

        static SnakeData()
        {
            Snakes = new List<Animal>();

            Snakes.Add(new Animal
            {
                Name = "Cape cobra",
                Location = "Africa",
                Details = "The Cape cobra (Naja nivea), also called the yellow cobra, is a moderate-sized, highly venomous species of cobra inhabiting a wide variety of biomes across southern Africa, including arid savanna, fynbos, bushveld, desert, and semidesert regions.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/3/3c/Naja_nivea.jpg"
            });

            Snakes.Add(new Animal
            {
                Name = "Boomslang",
                Location = "Africa",
                Details = "The boomslang (/ˈboʊmslɑːŋ/ or /ˈbɔːmsləŋ/; Dispholidus typus) is a highly venomous snake in the family Colubridae.[2] The species is native to Sub-Saharan Africa",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/25/Dispholidus_typus.jpg/1280px-Dispholidus_typus.jpg"
            });
        }
    }
}


