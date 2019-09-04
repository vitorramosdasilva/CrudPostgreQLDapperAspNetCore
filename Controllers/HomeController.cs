using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ASPCoreSample.Models;
using ASPCoreSample.Repository;
using Microsoft.AspNetCore.Mvc.Rendering;
using Dapper;
using System.Data.Common;
using System.Data;

namespace ASPCoreSample.Controllers
{
    public class HomeController : Controller
    {

        private readonly ProdutosRepository ProdutosRepository;
        private readonly CategoriasRepository CategoriasRepository;

        public HomeController(IConfiguration configuration)
        {
            ProdutosRepository = new ProdutosRepository(configuration);
            CategoriasRepository = new CategoriasRepository(configuration);
        }

           
        public IActionResult Index()
        {
            ViewData["Idcategoria"] = CategoriasRepository.FindAll();
            return View(ProdutosRepository.FindAll());
            //Categorias = CategoriasRepository.FindAll()});

        }


        public IActionResult Create()
        {

            //ViewData["Idcategoria"] = new SelectList(CategoriasRepository.FindAll(), "Id", "Descricao");
            return View();
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

            //ViewData["Idcategoria"] = new SelectList(CategoriasRepository.FindAll(), "Id", "Descricao", prod.Idcategoria);
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
            
            //ViewData["Idcategoria"] = new SelectList(CategoriasRepository.FindAll(), "Id", "Descricao", obj.Idcategoria);
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

            //ViewData["Idcategoria"] = new SelectList(CategoriasRepository.FindAll(), "Id", "Descricao", obj.Idcategoria);
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

        public IActionResult Privacy()
        {
            return View();
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
