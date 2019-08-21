using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ASPCoreSample.Models;
using ASPCoreSample.Repository;
 
namespace ASPCoreSample.Controllers
{
    public class StatusController : Controller
    {
        private readonly StatusRepository StatusRepository;
 
        public StatusController(IConfiguration configuration)
        {
            StatusRepository = new StatusRepository(configuration);
        }
 
 
        public IActionResult Index()
        {
            return View(StatusRepository.FindAll());
        }
 
        public IActionResult Create()
        {
            return View();
        }
 
        // POST: Status/Create
        [HttpPost]
        public IActionResult Create(Status cust)
        {
            if (ModelState.IsValid)
            {
                StatusRepository.Add(cust);
                return RedirectToAction("Index");
            }
            return View(cust);
 
        }
 
        // GET: /Status/Edit/1
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Status obj = StatusRepository.FindByID(id.Value);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
 
        }
 
        // POST: /Status/Edit   
        [HttpPost]
        public IActionResult Edit(Status obj)
        {
 
            if (ModelState.IsValid)
            {
                StatusRepository.Update(obj);
                return RedirectToAction("Index");
            }
            return View(obj);
        }
 
        // GET:/Status/Delete/1
        public IActionResult Delete(int? id)
        {
 
            if (id == null)
            {
                return NotFound();
            }
            StatusRepository.Remove(id.Value);
            return RedirectToAction("Index");
        }
    }
}
