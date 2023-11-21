using EcommercePatrick.Shared.Models;

namespace EcommercePatrick.Client.Services.ProductServices
{
    public class ProductServices : IProductServices
    {
        public List<Product> Products {  get; set; } = new List<Product>();

        public void LoadProducts()
        {
            Products = new List<Product>
            {
                new Product
                {
                Id = 1,
                CategoryId = 1,
                Title = "The Hitchhiker's Guide to the Galaxy",
                Description = "The Hitchhiker's Guide to the Galaxy is a comedy science fiction series",
                Image = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                Price = 9.99m,
                OriginalPrice = 19.99m,
                },
                new Product {
                Id = 2,
                CategoryId = 1,
                Title = "Ready Player One",
                Description = "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline.",
                Image="https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg",
                Price= 7.99m,
                OriginalPrice = 14.99m },

                new Product {
                Id = 3,
                CategoryId = 1,
                Title="Nineteen Eighty-Four",
                Description = "Nineteen Eighty-Four: A Novel, often published as 1984, is a dystopian social science fiction novel by English novelist",
                Image="https://upload.wikimedia.org/wikipedia/en/c/c3/1984first.jpg",
                Price = 6.99m},
                new Product {
                Id = 4,
                CategoryId = 2,
                Title= "Pentax Spotmatic",
                Description = "The Pentax Spotmatic refers to a family of 35mm single-lens reflex cameras manufactured by the Asahi Optical Co. Ltd.",
                Image = "https://upload.wikimedia.org/wikipedia/commons/e/e9/Honeywell-Pentax-Spotmatic.jpg",
                Price= 166.66m,
                OriginalPrice = 249.88m },
                new Product {
                Id = 5,
                CategoryId = 2,
                Title= "Xbox",
                Description = "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles",
                Image = "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg",
                Price = 159.99m,
                OriginalPrice = 299m
                },
                new Product{
                Id = 6,
                CategoryId = 2,
                Title = "Super Nintendo Entertainment System",
                Description = "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game.",
                Image = "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg",
                Price = 73.74m,
                OriginalPrice = 400m
                },
                new Product {
                Id = 7,
                CategoryId= 3,
                Title="Half-Life 2",
                Description="Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life.",
                Image = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                Price= 8.19m,
                OriginalPrice = 29.99m
                },
                new Product {
                Id = 8,
                CategoryId = 3,
                Title = "Diablo II",
                Description = "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Bliz.",
                Image = "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png",
                Price = 9.99m,
                OriginalPrice = 24.99m
                },
                new Product
                {
                Id = 9,
                CategoryId = 3,
                Title = "Day of the Tentacle",
                Description = "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed",
                Image = "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg",
                Price= 14.99m
                }
            };
        }
    }
}
