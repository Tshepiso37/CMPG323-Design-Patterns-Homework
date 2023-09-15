using OrgOffering.Models;

namespace OrgOffering.Repository
{
    public interface iProductRepository : IGenericRepository<Product>
    {
        Product GetMostRecentService();
    }
}
