using Microsoft.EntityFrameworkCore;
using OrgOffering.Data;
using OrgOffering.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrgOffering.Repository
{
    public class ServiceRepository : GenericRepository<Service>, iServiceRepository
    {
        public ServiceRepository(CMPG323Context context) : base(context)
        {
        }

        public Service GetMostRecentService()
        {
            return _context.Service.OrderByDescending(service => service.CreatedDate).FirstOrDefault();
        }

        public async Task<List<Service>> GetServicesAsync()
        {
            // Implement the method to retrieve a list of services asynchronously
            return await _context.Service.ToListAsync();
        }
    }
}
