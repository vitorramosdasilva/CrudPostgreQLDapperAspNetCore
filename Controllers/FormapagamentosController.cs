using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ASPCoreSample.Models;
using ASPCoreSample.Repository;
 
namespace ASPCoreSample.Controllers
{
    public class FormapagamentosController : Controller
    {
        private readonly FormapagamentosRepository FormapagamentosRepository;
 
        public FormapagamentosController(IConfiguration configuration)
        {
            FormapagamentosRepository = new FormapagamentosRepository(configuration);
        }
 
 
        public IActionResult Index()
        {
            return View(FormapagamentosRepository.FindAll());
        }
 
        public IActionResult Create()
        {
            return View();
        }
 
        // POST: Formapagamentos/Create
        [HttpPost]
        public IActionResult Create(Formapagamentos cust)
        {
            if (ModelState.IsValid)
            {
                FormapagamentosRepository.Add(cust);
                return RedirectToAction("Index");
            }
            return View(cust);
 
        }
 
        // GET: /Formapagamentos/Edit/1
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Formapagamentos obj = FormapagamentosRepository.FindByID(id.Value);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
 
        }
 
        // POST: /Formapagamentos/Edit   
        [HttpPost]
        public IActionResult Edit(Formapagamentos obj)
        {
 
            if (ModelState.IsValid)
            {
                FormapagamentosRepository.Update(obj);
                return RedirectToAction("Index");
            }
            return View(obj);
        }
 
        // GET:/Formapagamentos/Delete/1
        public IActionResult Delete(int? id)
        {
 
            if (id == null)
            {
                return NotFound();
            }
            FormapagamentosRepository.Remove(id.Value);
            return RedirectToAction("Index");
        }
    }
}
