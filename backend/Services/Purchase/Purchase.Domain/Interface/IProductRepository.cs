using Purchase.Domain.Entities;

namespace Purchase.Domain.Interface
{
    public interface IProductRepository:IGenericRepository<Product>
    {
        IEnumerable<Product> GetProductsByUnit(int unitId);
    }
}
