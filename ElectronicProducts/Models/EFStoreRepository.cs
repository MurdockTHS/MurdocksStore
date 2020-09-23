using System.Linq;

namespace ElectronicProducts.Models
{
    public class EFStoreRepository : IStoreRespository
    {
        private StoreDbContext context;

        public EFStoreRepository(StoreDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Product> Products => context.Products;
    }
}
