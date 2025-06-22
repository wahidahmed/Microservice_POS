using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Purchase.Domain.Entities;

namespace Purchase.Domain.Interface
{
    public interface IProductRepository:IGenericRepository<Product>
    {
        IEnumerable<Product> GetProductsByUnit(int unitId);
    }
}
