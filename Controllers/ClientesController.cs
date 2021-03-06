using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ASPCoreSample.Models;
using ASPCoreSample.Repository;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Dapper;
using System.Data.Common;
using System.Data;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace ASPCoreSample.Controllers
{
    public class ClientesController : Controller
    {
        private readonly ClientesRepository ClientesRepository;
        private readonly CidadesRepository CidadesRepository;
       
        public ClientesController(IConfiguration configuration)
        {
            ClientesRepository = new ClientesRepository(configuration);
            CidadesRepository = new CidadesRepository(configuration);
        }
    


        public IActionResult Index()
        {
            return View(ClientesRepository.FindAll());
        }


        public IActionResult Create()
        {

            ViewData["Idcidade"] = new SelectList(CidadesRepository.FindAll(), "Id", "Nome");
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        public IActionResult Create(Clientes cli)
        {
            if (ModelState.IsValid)
            {
                ClientesRepository.Add(cli);
                return RedirectToAction("Index");
            }

            ViewData["Idcidade"] = new SelectList(CidadesRepository.FindAll(), "Id", "Nome", cli.Idcidade);
            return View(cli);

        }



        // GET: /Clientes/Edit/1
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Clientes obj = ClientesRepository.FindByID(id.Value);
            if (obj == null)
            {
                return NotFound();
            }
            
            ViewData["Idcidade"] = new SelectList(CidadesRepository.FindAll(), "Id", "Nome", obj.Idcidade);
            return View(obj);

        }

        // POST: /Clientes/Edit   
        [HttpPost]
        public IActionResult Edit(Clientes obj)
        {

            if (ModelState.IsValid)
            {
                ClientesRepository.Update(obj);
                return RedirectToAction("Index");
            }

            ViewData["Idcidade"] = new SelectList(CidadesRepository.FindAll(), "Id", "Nome", obj.Idcidade);
            return View(obj);
        }

        // GET:/Clientes/Delete/1
        public IActionResult Delete(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }
            ClientesRepository.Remove(id.Value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Logout() 
        {  

            await HttpContext.SignOutAsync();  

            return RedirectToAction("Index", "Home");  

        }

        [HttpGet]
        public IActionResult Login()
        {  

            return View();  

        }  

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([Bind] Clientes user)
        {
            //ModelState.Remove("Email");
            //ModelState.Remove("Senha");

            const string SessionId = "Id";  

            if (user != null)
            {
                string LoginStatus = ClientesRepository.ValidateLogin(user);  

                if (LoginStatus == "Success")
                { 
                    Clientes cli = new Clientes();
                    cli = ClientesRepository.FindByEmail(user.Email);
                   
                    //Criando uma identidade para o usuário
                   
                    Claim claim1 = new Claim(ClaimTypes.Name, cli.Nome);                   
                    Claim claim2 = new Claim(ClaimTypes.Email, cli.Email);

                    IList<Claim> Claims = new List<Claim>() {                      
                        claim1,
                        claim2
                    };
                                                      
                    //Criando uma Identidade e associando-a ao ambiente. 
       
                    ClaimsIdentity userIdentity = new ClaimsIdentity(Claims, "Login");
                    ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                    await HttpContext.SignInAsync(principal);

                    HttpContext.Session.SetString(SessionId, cli.Id.ToString());
                    TempData["Id"] =  HttpContext.Session.GetString(SessionId);
                    //TempData["Id"] = cli.Id;

                    return RedirectToAction("Index", "Home");  

                }else{  

                    TempData["UserLoginFailed"] = "Login Failed.Please enter correct credentials";  

                    return View();  

                }  

            }  

            else  

                return View();  

        }  

    }  

} 


