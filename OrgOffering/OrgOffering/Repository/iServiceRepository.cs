using OrgOffering.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrgOffering.Repository
{
    public interface iServiceRepository : IGenericRepository<Service>
    {
        Service GetMostRecentService();
    }


}
