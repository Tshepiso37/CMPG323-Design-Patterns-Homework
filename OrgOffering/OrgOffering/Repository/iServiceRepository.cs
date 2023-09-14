using OrgOffering.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrgOffering.Repository
{
    public interface iServiceRepository : iGenericRepository<Service>
    {
        //object Service { get; }

        Service GetMostRecentService();
        Task<List<Service>> GetServicesAsync();
    }

}
