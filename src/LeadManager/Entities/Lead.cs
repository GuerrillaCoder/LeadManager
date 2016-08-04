using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeadManager.Entities
{
    public class Lead
    {
        public int LeadId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Budget Budget { get; set; }
        public string Description { get; set; }
        public DateTime Submitted { get; set; }
        public bool Assigned { get; set; }
    }

    public enum Budget
    {
        None,
        [Display(Name = "Not Sure")]
        NotSure,
        [Display(Name = "£0 - £999")]
        UpTo999,
        [Display(Name = "£1,000 - £4,999")]
        UpTo4999,
        [Display(Name = "£5,000 - £9,999")]
        UpTo9999,
        [Display(Name = "£10,000 - £19,999")]
        UpTo1999,
        [Display(Name = "£20,000+")]
        Over20000
    }
}
