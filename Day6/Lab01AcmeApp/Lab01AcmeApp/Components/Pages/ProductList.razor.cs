using Lab01AcmeApp.Models;
using Lab01AcmeApp.Services;
using Microsoft.AspNetCore.Components;

namespace Lab01AcmeApp.Components.Pages
{
    partial class ProductList
    {
        private List<Product> products = new();
        private List<Product> filteredProducts = new();
        private string displayRating = "";
        private bool showImage = false;
        private string searchTerm = "";

        [Inject]
        IProductService ProductService { get; set; }
        
        [Inject]
        NavigationManager NavigationManager { get; set; }


        private void FilterProducts(ChangeEventArgs e)
        {
            searchTerm = e.Value.ToString();
            if (!string.IsNullOrEmpty(searchTerm))
            {
                filteredProducts = products
                    .Where(p => p.ProductName.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }
            else
            {

                filteredProducts = ProductService.GetProducts();
            }

        }

        private void GotoToDetailsView(Product product)
        {
            Console.WriteLine("sected product is " + product.ProductName);
            NavigationManager.NavigateTo($"/product-details/{product.ProductId}");
        }

        private void ToggleImageDisplay()
        {

            showImage = !showImage;
        }

        //life cyle method called when the component is initialized

        protected override void OnInitialized()
        {
            products = ProductService.GetProducts();
            filteredProducts = products;
        }

        private void ShowRating(double rating)
        {
            displayRating = "select product with rating:" + rating;

        }
    }
}
