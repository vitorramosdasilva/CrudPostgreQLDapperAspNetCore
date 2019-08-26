using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ASPCoreSample.Models;
using ASPCoreSample.Repository;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Dapper;
using System.Data.Common;
using System.Data;

namespace ASPCoreSample.Controllers
{
    public class ItenspedidosController : Controller
    {
        private readonly ItenspedidosRepository ItenspedidosRepository;
        private readonly ProdutosRepository ProdutosRepository;
        //private readonly PedidosRepository ProdutosRepository;

        public ItenspedidosController(IConfiguration configuration)
        {
            ItenspedidosRepository = new ItenspedidosRepository(configuration);
            ProdutosRepository = new ProdutosRepository(configuration);
            //PedidosRepository = new PedidosRepository(configuration);
        }
    


        public IActionResult Index()
        {
            return View(ItenspedidosRepository.FindAll());
        }


        public IActionResult Create()
        {

            ViewData["Idproduto"] = new SelectList(ProdutosRepository.FindAll(), "Id", "Descricao");
            return View();
        }

        // POST: Itenspedidos/Create
        [HttpPost]
        public IActionResult Create(Itenspedidos prod)
        {
            if (ModelState.IsValid)
            {
                ItenspedidosRepository.Add(prod);
                return RedirectToAction("Index");
            }

            ViewData["Idproduto"] = new SelectList(ProdutosRepository.FindAll(), "Id", "Descricao", prod.Idproduto);
            return View(prod);

        }



        // GET: /Itenspedidos/Edit/1
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Itenspedidos obj = ItenspedidosRepository.FindByID(id.Value);
            if (obj == null)
            {
                return NotFound();
            }
            
            ViewData["Idproduto"] = new SelectList(ProdutosRepository.FindAll(), "Id", "Descricao", obj.Idproduto);
            return View(obj);

        }

        // POST: /Itenspedidos/Edit   
        [HttpPost]
        public IActionResult Edit(Itenspedidos obj)
        {

            if (ModelState.IsValid)
            {
                ItenspedidosRepository.Update(obj);
                return RedirectToAction("Index");
            }

            ViewData["Idproduto"] = new SelectList(ProdutosRepository.FindAll(), "Id", "Descricao", obj.Idproduto);
            return View(obj);
        }

        // GET:/Itenspedidos/Delete/1
        public IActionResult Delete(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }
            ItenspedidosRepository.Remove(id.Value);
            return RedirectToAction("Index");
        }


    }

}
