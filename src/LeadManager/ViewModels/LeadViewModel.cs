using LeadManager.Entities;
using System;
using System.ComponentModel.DataAnnotations;


namespace LeadManager.ViewModels
{
    public class LeadViewModel
    {
        public int LeadId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public Budget Budget { get; set; }
        public string Description { get; set; }
        public DateTime Submitted { get; set; }
        public bool Assigned { get; set; }
    }

}
