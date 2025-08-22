using ShoppingApp.Domain;
using ShoppingApp.GenericRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.BusinessObjects
{
    public class CatalogItemBO : ICatalogItemBO
    {

        private readonly ICatalogItemRepository _catalogItemRepository;
       // private readonly ICatalogBrandRepository _catalogBrandRepository;


        public CatalogItemBO(ICatalogItemRepository catlogItemRepo)
        { 
          _catalogItemRepository = catlogItemRepo;
        }

        
        public async Task<CatalogItem> Add(CatalogItem item)
        {
            await  _catalogItemRepository.Add(item);
            return item;
        }

        public async Task Delete(int id)
        {
           await _catalogItemRepository.Delete(id);
        }

        public async Task<CatalogItem> GetCatalogItemDetails(int id)
        {
            return await _catalogItemRepository.GetById(id);
        }

        public Task<IEnumerable<CatalogItem>> GetCatalogItems()
        {
            return _catalogItemRepository.GetAll();
        }

        public Task Update(CatalogItem item)
        {
            return _catalogItemRepository.Update(item);
        }
    }
}
