using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeadManager.Entities
{
    public class LeadRepository : ILeadRepository
    {
        private LeadDbContext _context;

        public LeadRepository(LeadDbContext context)
        {
            _context = context;
        }

        public Task<int> AddLead(Lead model)
        {
            _context.Leads.Add(model);
            return _context.SaveChangesAsync();
        }

        public IEnumerable<Lead> GetAllLeads()
        {
            return _context.Leads.ToList();
        }
    }
}
