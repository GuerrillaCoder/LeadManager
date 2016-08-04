using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LeadManager.Entities;
using LeadManager.ViewModels;
using AutoMapper;

namespace LeadManager.Controllers
{
    public class LeadController : Controller
    {
        private ILeadRepository _repository; 
        public LeadController(ILeadRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(LeadViewModel model)
        {
            if (ModelState.IsValid)
            {
                _repository.AddLead(Mapper.Map<Lead>(model));
                //_repository
                ViewBag.Message = "Saved Record: " + model.Name;
                ModelState.Clear();
            }
            else
            {
                ViewBag.Message = "Model didn't validate";
            }
            return View();
        }
    }
}
