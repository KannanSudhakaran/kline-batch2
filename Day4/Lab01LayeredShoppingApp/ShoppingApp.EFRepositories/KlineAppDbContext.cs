using Microsoft.EntityFrameworkCore;
using ShoppingApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ShoppingApp.EFRepositories
{
    public class KlineAppDbContext : DbContext
    {
        public KlineAppDbContext (DbContextOptions<KlineAppDbContext> options)
            : base(options)
        {
        }

        public DbSet<CatalogType> CatalogTypes { get; set; } = default!;
        public DbSet<CatalogBrand> CatalogBrands { get; set; } = default!;
        public DbSet<CatalogItem> CatalogItems { get; set; } = default!;
    }
}
