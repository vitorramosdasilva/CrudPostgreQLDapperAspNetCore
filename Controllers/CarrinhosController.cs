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
    public class CarrinhosController : Controller
    {
        private readonly CarrinhosRepository CarrinhosRepository;
        private readonly ProdutosRepository ProdutosRepository;
        

        public CarrinhosController(IConfiguration configuration)
        {
            CarrinhosRepository = new CarrinhosRepository(configuration);
            ProdutosRepository = new ProdutosRepository(configuration);
            
        }
    


        public IActionResult Index()
        {
            // if (TempData["Id"].ToString() != null){
            //   ViewBag.Id = TempData["Id"].ToString();  
            // }
            
            return View(CarrinhosRepository.FindAll());
        }

       
        public IActionResult Create(int id)
        {

            Produtos prod = ProdutosRepository.FindByID(id);

            if (prod == null)
            {
                return NotFound();
            }

            Carrinhos car = new Carrinhos();
            car.Idproduto = prod.Id;
            car.Nome = prod.Nome;
            car.Preco = prod.Preco;
            //car.Quantidade = 1;
                   
            CarrinhosRepository.Add(car);
            //ViewData["Idcliente"] = new SelectList(ClientesRepository.FindAll(), "Id", "Data");
            return RedirectToAction("Index");
        }

        // POST: Carrinhos/Create
        // [HttpPost]
        // public IActionResult Create(Carrinhos prod)
        // {
        //     if (ModelState.IsValid)
        //     {
        //         CarrinhosRepository.Add(prod);
        //         return RedirectToAction("Index");
        //     }

        //     ViewData["Idproduto"] = new SelectList(CarrinhosRepository.FindAll(), "Id", "Descricao", prod.Idproduto);
        //     //ViewData["Idpedido"] = new SelectList(ClientesRepository.FindAll(), "Id", "Data",prod.Idpedido);
        //     return View(prod);

        // }



        // GET: /Carrinhos/Edit/1
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Carrinhos obj = CarrinhosRepository.FindByID(id.Value);
            if (obj == null)
            {
                return NotFound();
            }
            
            ViewData["Idproduto"] = new SelectList(CarrinhosRepository.FindAll(), "Id", "Descricao", obj.Idproduto);
            
            return View(obj);

        }

        // POST: /Carrinhos/Edit   
        [HttpPost]
        public IActionResult Edit(Carrinhos obj)
        {

            if (ModelState.IsValid)
            {
                CarrinhosRepository.Update(obj);
                return RedirectToAction("Index");
            }

            ViewData["Idproduto"] = new SelectList(CarrinhosRepository.FindAll(), "Id", "Descricao", obj.Idproduto);
            
            return View(obj);
        }

        // GET:/Carrinhos/Delete/1
        public IActionResult Delete(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }
            CarrinhosRepository.Remove(id.Value);
            return RedirectToAction("Index");
        }


    }

}
