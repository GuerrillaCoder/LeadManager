using System.Collections.Generic;
using System.Threading.Tasks;

namespace LeadManager.Entities
{
    public interface ILeadRepository
    {
        IEnumerable<Lead> GetAllLeads();
        Task<int> AddLead(Lead model);
    }
}