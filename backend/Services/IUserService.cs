using System.Collections.Generic;
using System.Threading.Tasks;

namespace backend.ProductMaster
{
    public interface IProductProvider
    {
        Task<IEnumerable<Product>> Get();
    }
}