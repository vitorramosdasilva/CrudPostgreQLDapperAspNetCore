using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ASPCoreSample.Models;
using ASPCoreSample.Repository;
 
namespace ASPCoreSample.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly ProdutosRepository ProdutosRepository;
 
        public ProdutosController(IConfiguration configuration)
        {
            ProdutosRepository = new ProdutosRepository(configuration);
        }
 
 
        public IActionResult Index()
        {
            return View(ProdutosRepository.FindAll());
        }
 

        public IActionResult Create()
        {			
			List<Categorias> list = new List<Categorias>();
            ViewBag.CategoriasList = new SelectList(list, "Idcategoria", "Descricao" );

            return View(list);            
			//return View();
        }
 
        // POST: Produtos/Create
        [HttpPost]
        public IActionResult Create(Produtos prod)
        {
            if (ModelState.IsValid)
            {
                ProdutosRepository.Add(prod);
                return RedirectToAction("Index");
            }
            return View(prod);
 
        }
 
        // GET: /Produtos/Edit/1
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Produtos obj = ProdutosRepository.FindByID(id.Value);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
 
        }
 
        // POST: /Produtos/Edit   
        [HttpPost]
        public IActionResult Edit(Produtos obj)
        {
 
            if (ModelState.IsValid)
            {
                ProdutosRepository.Update(obj);
                return RedirectToAction("Index");
            }
            return View(obj);
        }
 
        // GET:/Produtos/Delete/1
        public IActionResult Delete(int? id)
        {
 
            if (id == null)
            {
                return NotFound();
            }
            ProdutosRepository.Remove(id.Value);
            return RedirectToAction("Index");
        }
    }
}