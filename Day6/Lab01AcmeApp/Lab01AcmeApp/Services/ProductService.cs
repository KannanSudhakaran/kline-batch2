using Lab01AcmeApp.Models;

namespace Lab01AcmeApp.Services
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
        {
            return new List<Product>
        {
            new Product
            {
                ProductId = 1,
                ProductName = "Leaf Rake",
                ProductCode = "GDN-0011",
                ReleaseDate = "March 19, 2016",
                Description = "Leaf rake with 48-inch wooden handle.",
                Price = 19.95,
                StarRating = 3.4,
                ImageUrl = "http://openclipart.org/image/300px/svg_to_png/26215/Anonymous_Leaf_Rake.png"
            },
            new Product
            {
                ProductId = 2,
                ProductName = "Garden Cart",
                ProductCode = "GDN-0023",
                ReleaseDate = "March 18, 2016",
                Description = "15 gallon capacity rolling garden cart",
                Price = 32.99,
                StarRating = 2.6,
                ImageUrl = "http://openclipart.org/image/300px/svg_to_png/58471/garden_cart.png"
            },
            new Product
            {
                ProductId = 5,
                ProductName = "Hammer",
                ProductCode = "TBX-0048",
                ReleaseDate = "May 21, 2016",
                Description = "Curved claw steel hammer",
                Price = 8.9,
                StarRating = 4.5,
                ImageUrl = "http://openclipart.org/image/300px/svg_to_png/73/rejon_Hammer.png"
            },
            new Product
            {
                ProductId = 8,
                ProductName = "Saw",
                ProductCode = "TBX-0022",
                ReleaseDate = "May 15, 2016",
                Description = "15-inch steel blade hand saw",
                Price = 11.55,
                StarRating = 3.2,
                ImageUrl = "http://openclipart.org/image/300px/svg_to_png/27070/egore911_saw.png"
            },
            new Product
            {
                ProductId = 10,
                ProductName = "Video Game Controller",
                ProductCode = "GMG-0042",
                ReleaseDate = "October 15, 2015",
                Description = "Standard two-button video game controller",
                Price = 35.95,
                StarRating = 3.9,
                ImageUrl = "http://openclipart.org/image/300px/svg_to_png/120337/xbox-controller_01.png"
            },
                        new Product
            {
                ProductId = 11,
                ProductName = "Paint Brush",
                ProductCode = "ART-0012",
                ReleaseDate = "June 12, 2017",
                Description = "Fine-tipped artist’s paint brush.",
                Price = 5.99,
                StarRating = 4.1,
                ImageUrl = "https://openclipart.org/image/300px/svg_to_png/169497/paint-brush.png"
            },
            new Product
            {
                ProductId = 12,
                ProductName = "Soccer Ball",
                ProductCode = "SPT-0033",
                ReleaseDate = "April 08, 2018",
                Description = "Standard size 5 soccer ball.",
                Price = 14.50,
                StarRating = 4.7,
                ImageUrl = "https://openclipart.org/image/300px/svg_to_png/21342/soccer_ball.png"
            },
            new Product
            {
                ProductId = 13,
                ProductName = "Laptop",
                ProductCode = "ELC-0029",
                ReleaseDate = "November 22, 2019",
                Description = "Lightweight 13-inch laptop computer.",
                Price = 899.99,
                StarRating = 4.3,
                ImageUrl = "https://openclipart.org/image/300px/svg_to_png/2821/laptop.png"
            },
            new Product
            {
                ProductId = 14,
                ProductName = "Basketball",
                ProductCode = "SPT-0044",
                ReleaseDate = "July 14, 2020",
                Description = "Official NBA size and weight basketball.",
                Price = 27.99,
                StarRating = 4.6,
                ImageUrl = "https://openclipart.org/image/300px/svg_to_png/27374/basketball.png"
            },
            new Product
            {
                ProductId = 15,
                ProductName = "Electric Drill",
                ProductCode = "TBX-0055",
                ReleaseDate = "September 1, 2021",
                Description = "Cordless electric drill with battery.",
                Price = 49.99,
                StarRating = 4.8,
                ImageUrl = "https://openclipart.org/image/300px/svg_to_png/202908/drill.png"
            }
        };
        }

    }
}
