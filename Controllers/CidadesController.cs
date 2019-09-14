using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ASPCoreSample.Models;
using ASPCoreSample.Repository;
 
namespace ASPCoreSample.Controllers
{
    public class CidadesController : Controller
    {
        private readonly CidadesRepository CidadesRepository;
 
        public CidadesController(IConfiguration configuration)
        {
            CidadesRepository = new CidadesRepository(configuration);
        }
 
 
        public IActionResult Index()
        {
            return View(CidadesRepository.FindAll());
        }
 
        public IActionResult Create()
        {
            return View();
        }
 
        // POST: Cidades/Create
        [HttpPost]
        public IActionResult Create(Cidades cust)
        {
            if (ModelState.IsValid)
            {
                CidadesRepository.Add(cust);
                return RedirectToAction("Index");
            }
            return View(cust);
 
        }
 
        // GET: /Cidades/Edit/1
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Cidades obj = CidadesRepository.FindByID(id.Value);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
 
        }
 
        // POST: /Cidades/Edit   
        [HttpPost]
        public IActionResult Edit(Cidades obj)
        {
 
            if (ModelState.IsValid)
            {
                CidadesRepository.Update(obj);
                return RedirectToAction("Index");
            }
            return View(obj);
        }
 
        // GET:/Cidades/Delete/1
        public IActionResult Delete(int? id)
        {
 
            if (id == null)
            {
                return NotFound();
            }
            CidadesRepository.Remove(id.Value);
            return RedirectToAction("Index");
        }
    }
}
