using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ASPCoreSample.Models;
using ASPCoreSample.Repository;
 
namespace ASPCoreSample.Controllers
{
    public class AdministradoresController : Controller
    {
        private readonly AdministradoresRepository AdministradoresRepository;
 
        public AdministradoresController(IConfiguration configuration)
        {
            AdministradoresRepository = new AdministradoresRepository(configuration);
        }
 
 
        public IActionResult Index()
        {
            return View(AdministradoresRepository.FindAll());
        }
 
        public IActionResult Create()
        {
            return View();
        }
 
        // POST: Administradores/Create
        [HttpPost]
        public IActionResult Create(Administradores cust)
        {
            if (ModelState.IsValid)
            {
                AdministradoresRepository.Add(cust);
                return RedirectToAction("Index");
            }
            return View(cust);
 
        }
 
        // GET: /Administradores/Edit/1
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Administradores obj = AdministradoresRepository.FindByID(id.Value);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
 
        }
 
        // POST: /Administradores/Edit   
        [HttpPost]
        public IActionResult Edit(Administradores obj)
        {
 
            if (ModelState.IsValid)
            {
                AdministradoresRepository.Update(obj);
                return RedirectToAction("Index");
            }
            return View(obj);
        }
 
        // GET:/Administradores/Delete/1
        public IActionResult Delete(int? id)
        {
 
            if (id == null)
            {
                return NotFound();
            }
            AdministradoresRepository.Remove(id.Value);
            return RedirectToAction("Index");
        }
    }
}
