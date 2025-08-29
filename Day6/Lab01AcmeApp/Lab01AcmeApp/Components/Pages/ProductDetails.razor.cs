using Lab01AcmeApp.Models;
using Lab01AcmeApp.Services;
using Microsoft.AspNetCore.Components;

namespace Lab01AcmeApp.Components.Pages
{
    partial class ProductDetails
    {

        [Parameter]
        public int id { get; set; }
        private Product product;
        [Inject]
        IProductService ProductService { get; set; }

        [Inject]
        NavigationManager NavigationManager { get; set; } 

        protected override void OnParametersSet()
        {
            product = ProductService.GetProducts()
                     .FirstOrDefault(pr => pr.ProductId == id);

        }

        private void BackToProductList()
        {
            NavigationManager.NavigateTo("/product-list");

        }
    }
}
