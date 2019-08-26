using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ASPCoreSample.Models;
using ASPCoreSample.Repository;
 
namespace ASPCoreSample.Controllers
{
    public class CategoriasController : Controller
    {
        private readonly CategoriasRepository CategoriasRepository;
 
        public CategoriasController(IConfiguration configuration)
        {
            CategoriasRepository = new CategoriasRepository(configuration);
        }

		 
        public IActionResult Index()
        {
            return View(CategoriasRepository.FindAll());
        }
 
        public IActionResult Create()
        {           
			return View();
        }
 
        // POST: Categorias/Create
        [HttpPost]
        public IActionResult Create(Categorias cust)
        {
            if (ModelState.IsValid)
            {
                CategoriasRepository.Add(cust);
                return RedirectToAction("Index");
            }
            return View(cust);
 
        }
 
        // GET: /Categorias/Edit/1
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Categorias obj = CategoriasRepository.FindByID(id.Value);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
 
        }
 
        // POST: /Categorias/Edit   
        [HttpPost]
        public IActionResult Edit(Categorias obj)
        {
 
            if (ModelState.IsValid)
            {
                CategoriasRepository.Update(obj);
                return RedirectToAction("Index");
            }
            return View(obj);
        }
 
        // GET:/Categorias/Delete/1
        public IActionResult Delete(int? id)
        {
 
            if (id == null)
            {
                return NotFound();
            }
            CategoriasRepository.Remove(id.Value);
            return RedirectToAction("Index");
        }
    }
}