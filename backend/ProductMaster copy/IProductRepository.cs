using System.Threading.Tasks;

namespace backend.ProductMaster
{
    public interface IProductRepository
    {
        Task Create(Product product);
    }
}