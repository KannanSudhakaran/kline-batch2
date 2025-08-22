using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingApp.BusinessObjects;
using System.Threading.Tasks;

namespace ShoppingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogItemController : ControllerBase
    {
        private readonly ICatalogItemBO _catalogItemBO;

        public CatalogItemController(ICatalogItemBO catalogItemBO)
        { 
          _catalogItemBO = catalogItemBO;
        }

        [HttpGet]
        public async Task<IActionResult> GetItems() {

          var items = await  _catalogItemBO.GetCatalogItems();
           return Ok(items);
        }
    }
}
