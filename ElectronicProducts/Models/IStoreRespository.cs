
using System.Linq;


namespace ElectronicProducts.Models
{
    public interface IStoreRespository
    {
        IQueryable<Product> Products { get; }
    }
}
