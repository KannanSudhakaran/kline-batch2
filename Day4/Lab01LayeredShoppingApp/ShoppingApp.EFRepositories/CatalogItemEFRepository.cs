using Microsoft.EntityFrameworkCore;
using ShoppingApp.Domain;
using ShoppingApp.GenericRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.EFRepositories
{
    public class CatalogItemEFRepository:BaseEFGenericRepository<CatalogItem>,ICatalogItemRepository
    {
        private readonly KlineAppDbContext _context;

        public CatalogItemEFRepository(KlineAppDbContext context)
             :base(context)
        { 
         _context = context;
        }


        public override async Task<IEnumerable<CatalogItem>> GetAll()
        {
            return await _context.CatalogItems
                    .Include(i => i.CatalogBrand)
                    .Include(i => i.CatalogType)
                    .ToListAsync();

        }
        
        public Task FilterCatalog(CatalogItem item)
        {
            throw new NotImplementedException();
        }
    }
}
