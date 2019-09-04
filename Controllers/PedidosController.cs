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
    public class PedidosController : Controller
    {
        private readonly PedidosRepository PedidosRepository;
        private readonly ClientesRepository ClientesRepository;
        private readonly StatusRepository StatusRepository;
        private readonly FormapagamentosRepository FormapagamentosRepository;


        public PedidosController(IConfiguration configuration)
        {
            PedidosRepository = new PedidosRepository(configuration);
            ClientesRepository = new ClientesRepository(configuration);
            StatusRepository = new StatusRepository(configuration);
            FormapagamentosRepository = new FormapagamentosRepository(configuration);
        }
    


        public IActionResult Index()
        {
            return View(PedidosRepository.FindAll());
        }


        public IActionResult Create()
        {

            ViewData["Idcliente"] = new SelectList(ClientesRepository.FindAll(), "Id", "Nome");                     
            ViewData["Idstatus"] = new SelectList(StatusRepository.FindAll(), "Id", "Situacao");
            ViewData["Idformapag"] = new SelectList(FormapagamentosRepository.FindAll(), "Id", "Descricao");

            return View();
        }

        // POST: Pedidos/Create
        [HttpPost]
        public IActionResult Create(Pedidos ped)
        {
            if (ModelState.IsValid)
            {
                PedidosRepository.Add(ped);
                return RedirectToAction("Index");
            }

            ViewData["Idcliente"] = new SelectList(ClientesRepository.FindAll(), "Id", "Nome", ped.Idcliente);                     
            ViewData["Idstatus"] = new SelectList(StatusRepository.FindAll(), "Id", "Situacao", ped.Idstatus);
            ViewData["Idformapag"] = new SelectList(FormapagamentosRepository.FindAll(), "Id", "Descricao", ped.Idformapag);
            
            return View(ped);

        }



        // GET: /Pedidos/Edit/1
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Pedidos obj = PedidosRepository.FindByID(id.Value);
            if (obj == null)
            {
                return NotFound();
            }
            
            ViewData["Idcliente"] = new SelectList(ClientesRepository.FindAll(), "Id", "Nome", obj.Idcliente);                     
            ViewData["Idstatus"] = new SelectList(StatusRepository.FindAll(), "Id", "Situacao", obj.Idstatus);
            ViewData["Idformapag"] = new SelectList(FormapagamentosRepository.FindAll(), "Id", "Descricao", obj.Idformapag);
            return View(obj);

        }

        // POST: /Pedidos/Edit   
        [HttpPost]
        public IActionResult Edit(Pedidos obj)
        {

            if (ModelState.IsValid)
            {
                PedidosRepository.Update(obj);
                return RedirectToAction("Index");
            }

            ViewData["Idcliente"] = new SelectList(ClientesRepository.FindAll(), "Id", "Nome", obj.Idcliente);                     
            ViewData["Idstatus"] = new SelectList(StatusRepository.FindAll(), "Id", "Situacao", obj.Idstatus);
            ViewData["Idformapag"] = new SelectList(FormapagamentosRepository.FindAll(), "Id", "Descricao", obj.Idformapag);
            
            return View(obj);
        }

        // GET:/Pedidos/Delete/1
        public IActionResult Delete(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }
            PedidosRepository.Remove(id.Value);
            return RedirectToAction("Index");
        }


    }

}
